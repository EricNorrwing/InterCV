using InterCV.Server.Models.Dtos.DtoMappers;
using InterCV.Server.Models.Dtos.UserDtos;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IUserService
{
    Task<UserDetailsDto?> GetCurrentUserAsync(); 
}
    
public class UserService(IUserRepository users, IAuthUserService authUser) : IUserService
{
    
    public async Task<UserDetailsDto?> GetCurrentUserAsync()
    {
        var userId = await authUser.GetCurrentUserId();
        
        if (userId == null)
            return null;
        
        var user = await users.GetUserByIdAsync(userId);

        return user.ToUserDetailsDto();
    }
    
}