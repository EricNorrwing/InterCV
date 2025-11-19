using InterCV.Server.Models.Dtos.UserDtos;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class UserMapper
{
    public static UserDetailsDto ToUserDetailsDto(this User user)
    {
        return new UserDetailsDto
        {
            Auth = user.Auth?.ToAuthUserDto(), 
            User = user.ToUserDto(),
            Profile = user.Profile?.ToUserProfileDto()
        };
    }

    //TODO make external?
    private static AuthUserDto? ToAuthUserDto(this AuthUser auth)
    {
        return new AuthUserDto
        {
            AuthExternalId = auth.AuthExternalId,
            CreatedAt = auth.CreatedAt,
            Email = auth.Email,
            EmailVerified = auth.EmailVerified,
            MfaEnabled = auth.MfaEnabled
        };
    }

    private static UserDto ToUserDto(this User user)
    {
        return new UserDto
        {
            Id = user.Id,
            Cvs = user.Cvs.Select(c => new CvDto { Id = c.Id }).ToList(),
            Experiences = user.Experiences.Select(e => new ExperienceDto { Id = e.Id }).ToList(),
            Educations = user.Educations.Select(ed => new EducationDto { Id = ed.Id }).ToList()
        };
    }

    private static UserProfileDto? ToUserProfileDto(this UserProfile profile)
    {
        return new UserProfileDto
        {
            FirstName = profile.FirstName,
            LastName = profile.LastName,
            Phone = profile.Phone,
            LinkedInUrl = profile.LinkedInUrl,
            DefaultTitle = profile.DefaultTitle
        };
    }
}