using System.ComponentModel.DataAnnotations;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Educations;

public class Education
{
    [Key]
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public required EducationType Type { get; set; }
    public required string Institution { get; set; }
    public required string Title { get; set; }

    public string? DescriptionShort { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Verification { get; set; }
}