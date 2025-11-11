using InterCV.Server.Models.CvModels.CvJunctionTables;
using InterCV.Server.Models.CvModels.Tags;
using InterCV.Server.Models.DTOs;

namespace InterCV.Server.Models.Dtos.DtoMappers;

public static class TagMapper
{
    public static TagDto ToDto(this Tag tag)
    {
        return new TagDto
        {
            Id = tag.Id,
            Name = tag.Name
        };
    }
}