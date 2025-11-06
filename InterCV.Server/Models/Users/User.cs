using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InterCV.Server.Models.CvModels;
using InterCV.Server.Models.CvModels.Educations;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.CvModels.Experiences.References;

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
