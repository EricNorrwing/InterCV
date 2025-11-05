using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Experiences.References;

public class Reference
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }

    public required string Title { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? PictureUrl { get; set; }

    public List<Reference>? Experiences { get; set; }
}