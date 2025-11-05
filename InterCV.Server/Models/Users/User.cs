using InterCV.Server.Models.CvModels;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.CvModels.Experiences.References;

namespace InterCV.Server.Models.Users;

public class User
{
    public Guid Id { get; set; }

    public AuthUser Auth { get; set; } = null!;
    public UserProfile? Profile { get; set; }

    public List<Cv> Cvs { get; set; } = [];
    public List<Experience> Experiences { get; set; } = [];
    public List<Education> Educations { get; set; } = [];
}
