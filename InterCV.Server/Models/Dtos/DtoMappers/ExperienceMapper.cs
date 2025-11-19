using InterCV.Server.Models.CvModels.Experiences;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class ExperienceMapper
{
    public static ExperienceDto ToDto(this Experience exp)
    {
        return new ExperienceDto
        {
            Id = exp.Id,
            Workplace = exp.Workplace,
            Title = exp.Title,
            StartDate = exp.StartDate,
            EndDate = exp.EndDate,
            DescriptionShort = exp.DescriptionShort,
            Description = exp.Description,
            Achievements = exp.Achievements.Select(a => a.Title).ToList(),
            References = exp.References.Select(r => new ReferenceDto
            {
                FirstName = r.FirstName,
                LastName = r.LastName,
                Title = r.Title,
                LinkedInUrl = r.LinkedInUrl,
                PictureUrl = r.PictureUrl,
                Email = r.Email,
                Phone = r.Phone
            }).ToList()
        };
    }
}