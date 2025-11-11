using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InterCV.Server.Repositories;

public class UserRepository (InterCvDbContext dbContext) 
{
    public async Task<EntityEntry<User>> AddNewUser(User user)
    {
        return await dbContext.Users.AddAsync(user);
    }
    
    public async Task<User?> GetUserByIdAsync(Guid userId)
    {
        return await dbContext.Users
            .Include(u => u.Auth)
            .Include(u => u.Profile)
            .FirstOrDefaultAsync(u => u.Id == userId);
    }
}