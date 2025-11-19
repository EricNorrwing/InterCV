using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Repositories;

public interface IAuthUserRepository
{
    Task<AuthUser?> GetAuthUserByIdAsync(string authId);
}

public class AuthUserRepository (InterCvDbContext db) : IAuthUserRepository
{
    public async Task<AuthUser?> GetAuthUserByIdAsync(string authId)
    {
        return await db.AuthUsers.FirstOrDefaultAsync(a => a.AuthExternalId == authId);
    }
}