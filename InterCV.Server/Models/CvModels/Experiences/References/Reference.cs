using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Experiences.References;

public class Reference
{
    public Guid Id { get; set; }

    public Guid ExperienceId { get; set; }
    public Experience Experience { get; set; } = null!;

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public string? Email { get; set; }
    public string? Phone { get; set; }

    public string? Title { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? PictureUrl { get; set; }
}