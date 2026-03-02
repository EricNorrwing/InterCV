using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Repositories;

public interface ICvRepository
{
    Task<Cv?> GetCvAsync();
}

public class CvRepository(InterCvDbContext dbContext) : ICvRepository
{
    public async Task<Cv?> GetCvAsync()
    {
        if (string.IsNullOrEmpty("sampleCvId"))
            return null;

        return await dbContext.Cvs
            .Include(c => c.User)
            .ThenInclude(u => u.Profile)
            .Include(c => c.User)
            .ThenInclude(u => u.Auth) 
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
            .FirstOrDefaultAsync(c => c.Id.ToString() == "sampleCvId");
    }
    
}