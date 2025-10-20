namespace InterCV.Server.Models.CvModels.Experiences;

public class ExperienceDetails
{
    public string DescriptionLong { get; set; } = string.Empty;
    public List<string>? Achievements { get; set; } 
    public List<ExperienceReference>? References { get; set; }
}