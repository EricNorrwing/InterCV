using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Educations;

public class Education
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; } 

    public required string Institution { get; set; }
    public required string Title { get; set; }
    public string? DescriptionShort { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public string? Verification { get; set; }
}