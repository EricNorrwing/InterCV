using InterCV.Server.Models.CvModels.Experiences;

namespace InterCV.Server.Models.CvModels.CvJunctionTables;

public class CvExperience
{
    public Guid CvId { get; set; }
    public required Cv Cv { get; set; }

    public Guid ExperienceId { get; set; }
    public required Experience Experience { get; set; }

    public int SortOrder { get; set; }
}