using InterCV.Server.Models.Users;

namespace InterCV.Server.Models.CvModels.Tags;

public class Tag
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public required string Name { get; set; }
}