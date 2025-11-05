using InterCV.Server.Models.CvModels.Experiences.References;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Experiences;

public class Experience
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; }

    public required string Title { get; set; }
    public required string Workplace { get; set; } 

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }
    public string? DescriptionShort { get; set; }

    public List<Reference>? References { get; set; }
    public List<Achievement>? Achievements { get; set; }
}