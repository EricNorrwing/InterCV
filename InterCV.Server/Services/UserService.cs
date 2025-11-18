using InterCV.Server.Models.Dtos.User;
using InterCV.Server.Models.DTOs.User;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IUserService
{
    Task<UserDetails?> GetCurrentUserAsync();
}
    
public class UserService(IUserRepository users, IAuthUserService authUser) : IUserService
{

    public async Task<UserDetails?> GetCurrentUserAsync()
    {
        var userId = authUser.GetCurrentUserId();
        if (userId == null)
            return null;

        var user = await users.GetUserByIdAsync(userId.Value);
        if (user == null)
            return null;

        return new UserDetails
        {
            User = new UserDto
            {
                Id = user.Id,
                Cvs = user.Cvs,
                Experiences = user.Experiences,
                Educations = user.Educations
            },
            userProfile = new UserProfileDto
            {
                FirstName = user.Profile?.FirstName,
                LastName = user.Profile?.LastName,
                Email = user.Profile?.Email,
                LinkedInUrl = user.Profile?.LinkedInUrl
            },
            AuthUserDto = new AuthUserDto
            {
                Sub = user.Auth?.Sub
            }
        };
    }
}