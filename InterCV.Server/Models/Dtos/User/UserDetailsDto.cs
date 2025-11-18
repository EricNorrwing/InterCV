namespace InterCV.Server.Models.Dtos.User;

public record UserDetailsDto
{
    public AuthUserDto Auth { get; init; } = null!;
    public UserDto User { get; init; } = null!;
    public UserProfileDto Profile { get; init; } = null!;
}