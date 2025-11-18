namespace InterCV.Server.Models.Dtos.UserDtos;

public record UserDto
{
    public Guid Id { get; init; }
    
    public List<CvDto> Cvs { get; init; } = new();
    public List<ExperienceDto> Experiences { get; init; } = new();
    public List<EducationDto> Educations { get; init; } = new();
}