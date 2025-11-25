using System.Security.Claims;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IAuthUserService
{
    Task<Guid> GetCurrentUserId();
    ClaimsPrincipal GetPrincipalFromCurrentUser();
    string GetExternalIdFromCurrentUser();
    string? GetEmailFromCurrentUser();
}

public class AuthUserService(IHttpContextAccessor httpContext, IAuthUserRepository authRepo)
    : IAuthUserService
{
    public ClaimsPrincipal GetPrincipalFromCurrentUser()
    {
        return httpContext.HttpContext?.User
               ?? throw new Exception("No user found in HttpContext.");
    }

    public string GetExternalIdFromCurrentUser()
    {
        var principal = GetPrincipalFromCurrentUser();

        return principal.FindFirstValue(ClaimTypes.NameIdentifier)
               ?? throw new Exception("No NameIdentifier (sub) claim found.");
    }

    public string? GetEmailFromCurrentUser()
    {
        var principal = GetPrincipalFromCurrentUser();
        return principal.FindFirstValue(ClaimTypes.Email); 
    }

    public async Task<Guid> GetCurrentUserId()
    {
        var externalId = GetExternalIdFromCurrentUser();

        var authUser = await authRepo.GetAuthUserByIdAsync(externalId)
                       ?? throw new Exception($"AuthUser not found for external ID '{externalId}'.");

        return authUser.UserId;
    }
}