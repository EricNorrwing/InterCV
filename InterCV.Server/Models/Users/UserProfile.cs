using System.ComponentModel.DataAnnotations;

namespace InterCV.Server.Models.Users;

public class UserProfile
{
    [Key]
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? DefaultTitle { get; set; }

}