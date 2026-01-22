using System.ComponentModel.DataAnnotations;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;

namespace InterCV.Server.Models.Users;

public class User
{
    [Key]
    public Guid Id { get; set; }

    public AuthUser? Auth { get; set; }
    public UserProfile? Profile { get; set; }

    public List<Cv> Cvs { get; set; } = new();
    public List<Experience> Experiences { get; set; } = new();
    public List<Education> Educations { get; set; } = new();
}
