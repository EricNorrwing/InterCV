namespace InterCV.Server.Models.CvModels.Experiences;

public class Experience
{
    public required string Workplace { get; set; }
    public required string Title { get; set; } 
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required string DescriptionShort { get; set; }
    public required ExperienceDetails Details { get; set; }
}