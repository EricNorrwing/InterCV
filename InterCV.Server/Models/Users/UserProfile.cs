using InterCV.Server.Models.UrlModels;

namespace InterCV.Server.Models.Users;

public class UserProfile
{
    public required string ProfilePictureUrl { get; set; }
    public required string PreferredProfessionalTitle { get; set; }
    public required string FirstName { get; set; } 
    public required string LastName { get; set; } 
    public required string Email { get; set; } 
    public required string Phone { get; set; } 
    public LinkedInUrl LinkedInUrl { get; set; }
}