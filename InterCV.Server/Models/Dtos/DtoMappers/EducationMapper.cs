using InterCV.Server.Models.CvModels.Educations;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class EducationMapper
{
    public static EducationDto ToDto(this Education education)
    {
        return new EducationDto
        {
            Id = education.Id,
            Institution = education.Institution,
            Title = education.Title,
            Type = education.Type.ToString(),
            DescriptionShort = education.DescriptionShort,
            StartDate = education.StartDate,
            EndDate = education.EndDate,
            Verification = education.Verification
        };
    }
}