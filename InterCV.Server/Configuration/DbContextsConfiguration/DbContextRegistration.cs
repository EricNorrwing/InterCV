using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Configuration.DbContextsConfiguration;

public static class DbContextRegistration
{
    public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DEV_AZURE_SQL_CONNECTION_STRING");
        
        services.AddDbContext<InterCvDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}