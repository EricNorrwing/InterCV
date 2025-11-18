using InterCV.Server.Models.Dtos.UserDtos;

namespace InterCV.Server.Models.Dtos;

public record CvDto
{
    public Guid Id { get; set; }
    public string AboutMe { get; set; } = string.Empty;
    public UserProfileDto Profile { get; set; } = null!;
    public List<ExperienceDto> Experiences { get; set; } = [];
    public List<EducationDto> Educations { get; set; } = [];
    public List<string> Tags { get; set; } = []; 
}