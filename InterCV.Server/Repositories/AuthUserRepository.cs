using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Repositories;

public interface IAuthUserRepository
{
    Task<AuthUser?> GetBySubAsync(string sub);
}

public class AuthUserRepository (InterCvDbContext db) : IAuthUserRepository
{
    public Task<AuthUser?> GetBySubAsync(string sub)
    {
        return db.AuthUsers.FirstOrDefaultAsync(a => a.AuthExternalId == sub);
    }
}