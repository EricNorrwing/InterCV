using InterCV.Server.Models.DTOs;

namespace InterCV.Server.Models.Dtos;

public class ExperienceDto
{
    public Guid Id { get; set; }
    public string Workplace { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string DescriptionShort { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<string> Achievements { get; set; } = new();
    public List<ReferenceDto> References { get; set; } = new(); 
}