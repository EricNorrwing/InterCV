using InterCV.Server.Models.CvModels.Experiences;

namespace InterCV.Server.Models.CvModels.CvJunctionTables;

public class CvExperience
{
    public Guid CvId { get; set; }
    public Cv Cv { get; set; } = null!;

    public Guid ExperienceId { get; set; }
    public Experience Experience { get; set; } = null!;
}
