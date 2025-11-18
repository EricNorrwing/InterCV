using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InterCV.Server.Repositories;

public interface IUserRepository
{
    Task<User?> GetUserByIdAsync(Guid userId);
    Task<EntityEntry<User>> AddUserAsync(User user);
}

public class UserRepository(InterCvDbContext dbContext) : IUserRepository
{
    public async Task<EntityEntry<User>> AddUserAsync(User user)
    {
        return await dbContext.Users.AddAsync(user);
    }

    public async Task<User?> GetUserByIdAsync(Guid userId)
    {
        return await dbContext.Users
            .Include(u => u.Auth)
            .Include(u => u.Profile)
            .Include(u => u.Cvs)
            .Include(u => u.Experiences)
            .Include(u => u.Educations)
            .FirstOrDefaultAsync(u => u.Id == userId);
    }
}