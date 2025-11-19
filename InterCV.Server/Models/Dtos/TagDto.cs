namespace InterCV.Server.Models.Dtos;

public record TagDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
