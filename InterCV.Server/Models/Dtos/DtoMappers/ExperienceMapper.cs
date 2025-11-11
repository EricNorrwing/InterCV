using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.DTOs;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class ExperienceMapper
{
    public static ExperienceDto ToDto(this Experience exp)
    {
        return new ExperienceDto
        {
            Id = exp.Id,
            Title = exp.Title,
            Workplace = exp.Workplace,
            StartDate = exp.StartDate,
            EndDate = exp.EndDate,
            DescriptionShort = exp.DescriptionShort,
            Description = exp.Description,
            Achievements = exp.Achievements?
                .Select(a => a.ToDto())
                .ToList() ?? new List<AchievementDto>(),
            References = exp.References?
                .Select(r => r.ToDto())
                .ToList() ?? new List<ReferenceDto>()
        };
    }
}