using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Repositories;

public interface IAuthUserRepository
{
    Task<AuthUser?> GetAuthUserByIdAsync(string authId);
    Task<AuthUser> CreateAuthUserAsync(AuthUser user);
}

public class AuthUserRepository(InterCvDbContext db) : IAuthUserRepository
{
    public Task<AuthUser?> GetAuthUserByIdAsync(string authId)
        => db.AuthUsers.FirstOrDefaultAsync(a => a.AuthExternalId == authId);

    public async Task<AuthUser> CreateAuthUserAsync(AuthUser user)
    {
        db.AuthUsers.Add(user);
        await db.SaveChangesAsync();
        return user;
    }
}