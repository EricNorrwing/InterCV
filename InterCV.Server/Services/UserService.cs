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
    
public class UserService(IUserRepository usersRepo, IAuthUserService authUser, IAuthUserRepository authRepo) : IUserService
{
    
    public async Task<UserDetailsDto?> GetCurrentUserAsync()
    {
        var userId = await authUser.GetCurrentUserId();

        var user = await usersRepo.GetUserByIdAsync(userId);

        return user.ToUserDetailsDto();
        
    }
    

    public async Task<User> GetUserByIdAsync(Guid userId)
    {
        return await usersRepo.GetUserByIdAsync(userId);
    }

    public async Task<User> AutoCreateUserIfNewAsync()
    {
        var principal = authUser.GetPrincipalFromCurrentUser();

        var email = authUser.GetEmailFromCurrentUser();
        //TODO global error handling
        if (email == null)
            throw new Exception("Logged-in user has no email claim.");
        //TODO same here
        var existingUser = await usersRepo.GetUserByEmailAsync(email);
        if (existingUser != null)
            return existingUser;
        
        var authEntity = CreateAuthUser(principal);
        authEntity = await authRepo.CreateAuthUserAsync(authEntity);
        
        var user = CreateUser(principal);
        user.Id = authEntity.UserId;
        user.Auth = authEntity;
        
        user = await usersRepo.CreateUserAsync(user);

        return user;
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
            LastName = principal.FindFirstValue(ClaimTypes.Surname) ?? "",
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