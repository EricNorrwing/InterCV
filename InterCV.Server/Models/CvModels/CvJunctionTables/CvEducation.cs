using InterCV.Server.Models.CvModels.Educations;

namespace InterCV.Server.Models.CvModels.CvJunctionTables;

public class CvEducation
{
    public Guid CvId { get; set; }
    public Cv Cv { get; set; } = null!;

    public Guid EducationId { get; set; }
    public Education Education { get; set; } = null!;
}