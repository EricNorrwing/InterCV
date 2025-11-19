using InterCV.Server.Models.CvModels.Tags;

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