namespace InterCV.Server.Models.DTOs.DtoMappers;

public static class CvMapper
{
    public static CvDto ToDto(this Cv cv)
    {
        return new CvDto
        {
            Id = cv.Id,
            AboutMe = cv.AboutMe,
            Profile = cv.User?.Profile != null
                ? new UserProfileDto
                {
                    FirstName = cv.User.Profile.FirstName,
                    LastName = cv.User.Profile.LastName,
                    Phone = cv.User.Profile.Phone,
                    LinkedInUrl = cv.User.Profile.LinkedInUrl,
                    DefaultTitle = cv.User.Profile.DefaultTitle
                }
                : null,

            Experiences = cv.Experiences
                .Select(ce => ce.Experience)
                .Where(e => e != null)
                .Select(e => new ExperienceDto
                {
                    Id = e.Id,
                    Title = e.Title,
                    Workplace = e.Workplace,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    DescriptionShort = e.DescriptionShort,
                    Description = e.Description,
                    Achievements = e.Achievements.Select(a => new AchievementDto
                    {
                        Title = a.Title
                    }).ToList(),
                    References = e.References.Select(r => new ReferenceDto
                    {
                        FirstName = r.FirstName,
                        LastName = r.LastName,
                        Title = r.Title,
                        LinkedInUrl = r.LinkedInUrl,
                        Email = r.Email,
                        Phone = r.Phone,
                        PictureUrl = r.PictureUrl
                    }).ToList()
                }).ToList(),

            Educations = cv.Educations
                .Select(ed => ed.Education)
                .Where(ed => ed != null)
                .Select(ed => new EducationDto
                {
                    Id = ed.Id,
                    Institution = ed.Institution,
                    Title = ed.Title,
                    DescriptionShort = ed.DescriptionShort,
                    StartDate = ed.StartDate,
                    EndDate = ed.EndDate,
                    Type = ed.Type.ToString(),
                    Verification = ed.Verification
                }).ToList(),

            Tags = cv.Tags
                .Select(t => new TagDto { Name = t.Tag.Name })
                .ToList()
        };
    }
}
