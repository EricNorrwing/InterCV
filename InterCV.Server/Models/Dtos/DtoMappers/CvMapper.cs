using InterCV.Server.Models.DTOs;
using InterCV.Server.Models.DTOs.DtoMappers;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class CvMapper
{
    public static CvDto ToDto(this Cv cv)
    {
        if (cv == null) return null!;

        return new CvDto
        {
            Id = cv.Id,
            AboutMe = cv.AboutMe,
            Profile = cv.User?.Profile?.ToDto(),
            Experiences = cv.Experiences?
                .Select(ce => ce.Experience.ToDto())
                .ToList() ?? new List<ExperienceDto>(),
            Educations = cv.Educations?
                .Select(ce => ce.Education.ToDto())
                .ToList() ?? new List<EducationDto>(),
            Tags = cv.Tags?
                .Select(ct => ct.Tag.ToDto())
                .ToList() ?? new List<TagDto>()
        };
    }
}