namespace InterCV.Server.Models.DTOs;

public class ExperienceDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Workplace { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? DescriptionShort { get; set; }
    public string? Description { get; set; }

    public List<AchievementDto> Achievements { get; set; } = new();
    public List<ReferenceDto> References { get; set; } = new();
}
