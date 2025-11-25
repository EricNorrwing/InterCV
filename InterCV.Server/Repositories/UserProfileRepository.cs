using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;

namespace InterCV.Server.Repositories;

public interface IUserProfileRepository
{
    Task<UserProfile> CreateProfileAsync(UserProfile profile);
}

public class UserProfileRepository(InterCvDbContext db): IUserProfileRepository
{
    public async Task<UserProfile> CreateProfileAsync(UserProfile profile)
    {
        db.UserProfiles.Add(profile);
        await db.SaveChangesAsync();
        return profile;
    }
}