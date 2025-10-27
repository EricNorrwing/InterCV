using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels;

public class CvModel
{
    public required List<Experience> Experiences { get; set; }
    public required List<Education> Educations { get; set; }
    public required string AboutMe { get; set; }
    public List<string>? Tags { get; set; }
    public required UserProfile User { get; set; }
    public List<UserData>? UserData { get; set; }
}