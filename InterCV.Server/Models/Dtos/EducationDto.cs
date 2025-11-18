namespace InterCV.Server.Models.Dtos;

public record EducationDto
{
    public Guid Id { get; set; }
    public string? Institution { get; set; }
    public string? Title { get; set; }
    public string? DescriptionShort { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Type { get; set; }
    public string? Verification { get; set; }
}