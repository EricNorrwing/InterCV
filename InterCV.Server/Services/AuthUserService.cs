using System.Security.Claims;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IAuthUserService
{
    Task<Guid> GetCurrentUserId();
}

public class AuthUserService(IHttpContextAccessor httpContext, IAuthUserRepository authRepo)
    : IAuthUserService
{
    public async Task<Guid> GetCurrentUserId()
    {
        var principal = httpContext.HttpContext?.User
                        ?? throw new Exception("No HttpContext user found.");

        var sub = principal.FindFirstValue(ClaimTypes.NameIdentifier)
                  ?? throw new Exception("No NameIdentifier claim found on user.");

        var authUser = await authRepo.GetAuthUserByIdAsync(sub)
                       ?? throw new Exception($"No AuthUser found for external ID '{sub}'.");

        return authUser.UserId;
    }
}