using System.ComponentModel.DataAnnotations;
using InterCV.Server.Models.CvModels.CvJunctionTables;
using InterCV.Server.Models.CvModels.Tags;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Models;

public class Cv
{
    [Key]
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public string? AboutMe { get; set; }

    public List<CvExperience> Experiences { get; set; } = new();
    public List<CvEducation> Educations { get; set; } = new();
    public List<CvTag> Tags { get; set; } = new();
}