namespace InterCV.Server.Models.Dtos;

public record ReferenceDto
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Title { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? PictureUrl { get; set; }
}
