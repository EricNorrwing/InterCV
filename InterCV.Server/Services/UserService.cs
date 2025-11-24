using InterCV.Server.Models.Dtos.DtoMappers;
using InterCV.Server.Models.Dtos.UserDtos;
using InterCV.Server.Models.Users;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IUserService
{
    Task<UserDetailsDto?> GetCurrentUserAsync(); 
    Task<User> GetUserByIdAsync(Guid userId);
}
    
public class UserService(IUserRepository users, IAuthUserService authUser) : IUserService
{
    
    public async Task<UserDetailsDto?> GetCurrentUserAsync()
    {
        var userId = await authUser.GetCurrentUserId();
        
        var user = await users.GetUserByIdAsync(userId);

        return user.ToUserDetailsDto();
    }

    public async Task<User> GetUserByIdAsync(Guid userId)
    {
        return await users.GetUserByIdAsync(userId);
    }
}