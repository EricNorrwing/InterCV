using InterCV.Server.Models.CvModels.Experiences.References;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class ReferenceMapper
{
    public static ReferenceDto ToDto(this Reference reference)
    {
        return new ReferenceDto
        {
            Id = reference.Id,
            FirstName = reference.FirstName,
            LastName = reference.LastName,
            Title = reference.Title,
            LinkedInUrl = reference.LinkedInUrl,
            Email = reference.Email,
            Phone = reference.Phone,
            PictureUrl = reference.PictureUrl
        };
    }
}