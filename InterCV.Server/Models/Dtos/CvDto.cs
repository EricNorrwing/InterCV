namespace InterCV.Server.Models.DTOs;

public class CvDto
{
    public Guid Id { get; set; }
    public string? AboutMe { get; set; }
    public UserProfileDto? Profile { get; set; }
    public List<ExperienceDto> Experiences { get; set; } = new();
    public List<EducationDto> Educations { get; set; } = new();
    public List<TagDto> Tags { get; set; } = new();
}