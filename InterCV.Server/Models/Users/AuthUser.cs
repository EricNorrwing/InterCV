using System.ComponentModel.DataAnnotations;

namespace InterCV.Server.Models.Users;

public class AuthUser
{
    [Key]
    public Guid UserId { get; set; }
    public required User User { get; set; }

    public required string AuthUserId { get; set; }
    public required string Email { get; set; }
    public bool EmailVerified { get; set; }

    public DateTime CreatedAt { get; set; }
    public bool MfaEnabled { get; set; }
}