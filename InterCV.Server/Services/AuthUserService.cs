using System.Security.Claims;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IAuthUserService
{
    Task<Guid> GetCurrentUserId();
}

public class AuthUserService(IHttpContextAccessor httpContext, IAuthUserRepository authRepo) : IAuthUserService
{
    public async Task<Guid> GetCurrentUserId()
    {
        var user = httpContext.HttpContext?.User;

        var sub = user.FindFirstValue(ClaimTypes.NameIdentifier);

        var authUser = await authRepo.GetAuthUserByIdAsync(sub);
        return authUser?.UserId;
    }
}