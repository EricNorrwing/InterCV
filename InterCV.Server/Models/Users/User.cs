using InterCV.Server.Models.CvModels;

namespace InterCV.Server.Models.Users;

public class User
{
    public int Id { get; set; }
    public required string AuthId { get; set; }
    public string? Email { get; set; }

    public UserProfile? Profile { get; set; }

    public List<CvModel>? Cvs { get; set; }
}