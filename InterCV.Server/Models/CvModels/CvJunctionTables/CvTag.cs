using InterCV.Server.Models.CvModels.Tags;

namespace InterCV.Server.Models.CvModels.CvJunctionTables;


public class CvTag
{
    public Guid CvId { get; set; }
    public Cv Cv { get; set; } = null!;

    public Guid TagId { get; set; }
    public Tag Tag { get; set; } = null!;
}