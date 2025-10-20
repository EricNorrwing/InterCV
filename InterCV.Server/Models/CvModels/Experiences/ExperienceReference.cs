using InterCV.Server.Models.UrlModels;

namespace InterCV.Server.Models.CvModels.Experiences;

public class ExperienceReference
{
    public required string FirstName { get; set; } 
    public required string LastName { get; set; }
    public required string Title { get; set; }
    public required string LinkedInUrl { get; set; } 
    public required string Email { get; set; }
    public required string Phone { get; set; } 
    public required InterCvUrl InterCvProfile { get; set; }
}