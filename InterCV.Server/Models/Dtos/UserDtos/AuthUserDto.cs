namespace InterCV.Server.Models.Dtos.UserDtos;

public record AuthUserDto
{
    public required string AuthExternalId { get; set; }
    public required string Email { get; set; }
    public required bool EmailVerified  { get; set; }
    public required bool MfaEnabled { get; set; }
    public required DateTime CreatedAt { get; set; }
}


