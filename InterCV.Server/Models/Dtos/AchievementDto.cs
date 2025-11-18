namespace InterCV.Server.Models.Dtos;

public record AchievementDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
}