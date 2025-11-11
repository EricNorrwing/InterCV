using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.DTOs.DtoMappers;

public static class UserProfileMapper
{
    public static UserProfileDto ToDto(this UserProfile profile)
    {
        return new UserProfileDto
        {
            FirstName = profile.FirstName,
            LastName = profile.LastName,
            Phone = profile.Phone,
            LinkedInUrl = profile.LinkedInUrl,
            DefaultTitle = profile.DefaultTitle,
        };
    }
}