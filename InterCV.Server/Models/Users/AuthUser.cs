using System.ComponentModel.DataAnnotations;

namespace InterCV.Server.Models.Users;

public class AuthUser
{
    [Key]
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public required string AuthExternalId { get; set; }
    public required string Email { get; set; }
    public bool EmailVerified { get; set; }
    public bool MfaEnabled { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}