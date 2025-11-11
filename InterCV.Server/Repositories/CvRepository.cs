using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Repositories;

public class CvRepository(InterCvDbContext dbContext, AppSettingsReader appSettingsReader)
{
    public async Task<Cv?> GetSampleCv()
    {
        try
        {
            string sampleCvId = appSettingsReader.ExposeSettings("SampleCvId");

            return await dbContext.Cvs
                .FirstOrDefaultAsync(x => x.Id.ToString() == sampleCvId);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }
    
}