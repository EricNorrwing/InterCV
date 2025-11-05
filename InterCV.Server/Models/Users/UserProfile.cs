using System.ComponentModel.DataAnnotations;
using InterCV.Server.Models.UrlModels;

namespace InterCV.Server.Models.Users;

public class UserProfile
{
    [Key]
    public Guid UserId { get; set; }
    public required User User { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? DefaultTitle { get; set; }
}