namespace InterCV.Server.Models.CvModels.Experiences;

public class Achievement
{
    public Guid Id { get; set; }

    public Guid ExperienceId { get; set; }
    public Experience Experience { get; set; } = null!;

    public required string Title { get; set; }
    public string? Description { get; set; }
}