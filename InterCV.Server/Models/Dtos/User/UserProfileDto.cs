namespace InterCV.Server.Models.Dtos.User;

public record UserProfileDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? DefaultTitle { get; set; }
    public string? Email { get; set; }
}