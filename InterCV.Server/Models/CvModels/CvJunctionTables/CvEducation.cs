using InterCV.Server.Models.CvModels.Educations;

namespace InterCV.Server.Models.CvModels.CvJunctionTables;

public class CvEducation
{
    public Guid CvId { get; set; }
    public required Cv Cv { get; set; }

    public Guid EducationId { get; set; }
    public required Education Education { get; set; }

    public int SortOrder { get; set; }
}