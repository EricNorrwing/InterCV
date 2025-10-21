namespace InterCV.Server.Models.CvModels.Educations;

public class Education
{
    public required bool Formal { get; set; }
    public required string EducationName { get; set; }
    public string? Title { get; set; }
    public required string Provider { get; set; } = string.Empty;
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required string Description { get; set; } = string.Empty;
    public string? VerificationUrl { get; set; }
}