using System.Security.Claims;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IAuthUserService
{
    Task<Guid?> GetCurrentUserId();
}

public class AuthUserService(IHttpContextAccessor httpContext, IAuthUserRepository authRepo) : IAuthUserService
{
    public async Task<Guid?> GetCurrentUserId()
    {
        var user = httpContext.HttpContext?.User;
        if (user == null) return null;

        var sub = user.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(sub)) return null;

        var authUser = await authRepo.GetBySubAsync(sub);
        return authUser?.UserId;
    }
}