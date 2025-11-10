using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models;
using InterCV.Server.Models.CvModels.Experiences;
using InterCV.Server.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Repositories;

public class TestRepository(InterCvDbContext dbContext)
{
    /// <summary>
    /// Fetch the first CV for a given user
    /// </summary>
    public async Task<List<Cv>> GetAllCvsForUserAsync(Guid userId)
    {
        var cvs = await dbContext.Cvs
            .Where(c => c.UserId == userId)
            .ToListAsync();

        Console.WriteLine($"Found {cvs.Count} CV(s) for user {userId}");
        return cvs;
    }
    public async Task<List<Experience>> GetExperiencesForUserAsync(Guid userId)
    {
        return await dbContext.Experiences
            .Where(e => e.UserId == userId)
            .ToListAsync();
    }
    
    public async Task<Cv?> GetFirstCvForUserAsync(Guid userId)
    {
        return await dbContext.Cvs
            .Where(c => c.UserId == userId)
            .Include(c => c.Experiences)
            .ThenInclude(ce => ce.Experience)
            .ThenInclude(e => e.Achievements)
            .Include(c => c.Experiences)
            .ThenInclude(ce => ce.Experience)
            .ThenInclude(e => e.References)
            .Include(c => c.Educations)
            .ThenInclude(ce => ce.Education)
            .Include(c => c.Tags)
            .ThenInclude(ct => ct.Tag)
            .FirstOrDefaultAsync();
    }
    
    public async Task<SimpleCvDto?> GetSimpleCvForUserAsync(Guid userId)
    {
        var cv = await dbContext.Cvs
            .Where(c => c.UserId == userId)
            .Include(c => c.User)
            .ThenInclude(u => u.Profile)
            .FirstOrDefaultAsync();

        if (cv == null) return null;

        return new SimpleCvDto
        {
            UserName = cv.User.Profile != null 
                ? $"{cv.User.Profile.FirstName} {cv.User.Profile.LastName}" 
                : "Unknown",
            AboutMe = cv.AboutMe ?? string.Empty
        };
    }
}