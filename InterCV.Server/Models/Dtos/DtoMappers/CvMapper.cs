using InterCV.Server.Models.Dtos.User;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class CvMapper
{
    public static CvDto ToDto(this Cv cv)
    {
        return new CvDto
        {
            Id = cv.Id,
            AboutMe = cv.AboutMe,
            Profile = new UserProfileDto
            {
                FirstName = cv.User.Profile.FirstName,
                LastName = cv.User.Profile.LastName,
                Phone = cv.User.Profile.Phone,
                LinkedInUrl = cv.User.Profile.LinkedInUrl,
                DefaultTitle = cv.User.Profile.DefaultTitle,
                Email = cv.User.Auth.Email,
            },
            Experiences = cv.Experiences
                .Select(ce => ce.Experience.ToDto()) 
                .ToList(),
            Educations = cv.Educations
                .Select(ce => ce.Education.ToDto())
                .ToList(),
            Tags = cv.Tags
                .Select(ct => ct.Tag.Name) 
                .ToList()
        };
    }
}