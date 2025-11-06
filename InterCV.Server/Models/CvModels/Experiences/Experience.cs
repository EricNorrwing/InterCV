using System.ComponentModel.DataAnnotations;
using InterCV.Server.Models.CvModels.Experiences.References;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Experiences;

public class Experience
{
    [Key]
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public required string Title { get; set; }
    public required string Workplace { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }
    public string? DescriptionShort { get; set; }

    public List<Reference> References { get; set; } = new();
    public List<Achievement> Achievements { get; set; } = new();
}