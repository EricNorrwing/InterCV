using InterCV.Server.Models.Dtos;

namespace InterCV.Server.Models.Dtos.User;

public record UserDto
{
    public Guid Id { get; init; }
    
    public List<CvDto> Cvs { get; init; } = new();
    public List<ExperienceDto> Experiences { get; init; } = new();
    public List<EducationDto> Educations { get; init; } = new();
}