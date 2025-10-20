using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels;

public class CvModel
{
    public required List<Experience> Experiences { get; set; }
    public required UserProfile User { get; set; }
    public List<UserData>? UserData { get; set; }
}