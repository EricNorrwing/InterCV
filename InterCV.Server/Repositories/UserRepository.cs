using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InterCV.Server.Repositories;

public interface IUserRepository
{
    Task<User?> GetUserByIdAsync(Guid userId);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User> CreateUserAsync(User user);

}

public class UserRepository(InterCvDbContext db) : IUserRepository
{
    public Task<User?> GetUserByIdAsync(Guid userId)
        => db.Users
            .Include(u => u.Auth)
            .Include(u => u.Profile)
            .Include(u => u.Cvs)
            .Include(u => u.Experiences)
            .Include(u => u.Educations)
            .FirstOrDefaultAsync(u => u.Id == userId);

    public Task<User?> GetUserByEmailAsync(string email)
        => db.Users
            .Include(u => u.Auth)
            .FirstOrDefaultAsync(u => u.Auth.Email == email);

    public async Task<User> CreateUserAsync(User user)
    {
        db.Users.Add(user);
        await db.SaveChangesAsync();
        return user;
    }
    
}