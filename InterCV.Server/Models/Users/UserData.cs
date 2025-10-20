namespace InterCV.Server.Models.Users;

public class UserData
{
    public List<UserProfile>? Visitors { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime LastVisited { get; set; }
}