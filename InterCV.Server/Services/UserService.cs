using System.Security.Claims;
using InterCV.Server.Models;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.Dtos.DtoMappers;
using InterCV.Server.Models.Dtos.UserDtos;
using InterCV.Server.Models.Users;
using InterCV.Server.Repositories;

namespace InterCV.Server.Services;

public interface IUserService
{
    Task<UserDetailsDto?> GetCurrentUserAsync(); 
    Task<User> GetUserByIdAsync(Guid userId);

    Task<User> AutoCreateUserIfNewAsync();
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

    public async Task<User> AutoCreateUserIfNewAsync()
    {
        var principal = authUser.GetPrincipalFromCurrentUser();
        
        var existingUser = await users.GetUserByEmailAsync(authUser.GetEmailFromCurrentUser());
        if (existingUser != null)
            return existingUser;
        
        var newAuth = CreateAuthUser(principal);
        newAuth = await users.CreateAuthUserAsync(newAuth);
        
        var newUser = CreateUser(principal);
        newUser.Id = newAuth.UserId; 

        newUser = await users.CreateUserAsync(newUser);

        return newUser;
    }
    
    
    private static User CreateUser(ClaimsPrincipal principal)
    {
        return new User
        {
            Profile = CreateUserProfile(principal),
            Cvs = new List<Cv>(),
            Experiences = new List<Experience>(),
            Educations = new List<Education>()
        };
    }
    
    private static UserProfile CreateUserProfile(ClaimsPrincipal principal)
    {
        return new UserProfile
        {
            FirstName = principal.FindFirstValue(ClaimTypes.GivenName) ?? "",
            LastName  = principal.FindFirstValue(ClaimTypes.Surname) ?? "",
            Phone = "",
            LinkedInUrl = "",
            PictureUrl = principal.FindFirstValue("picture") ?? "",
            DefaultTitle = ""
        };
    }

    private static AuthUser CreateAuthUser(ClaimsPrincipal principal)
    {
        bool emailVerified = bool.TryParse(
            principal.FindFirstValue("email_verified"),
            out var verified
        ) && verified;

        return new AuthUser
        {
            AuthExternalId = principal.FindFirstValue(ClaimTypes.NameIdentifier) ?? "",
            Email = principal.FindFirstValue(ClaimTypes.Email) ?? "",
            EmailVerified = emailVerified,
            MfaEnabled = false,
            CreatedAt = DateTime.UtcNow
        };
    }
    
}