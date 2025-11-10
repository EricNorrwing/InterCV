using InterCV.Server.Configuration.DbContextsConfiguration;
using InterCV.Server.Configuration.ServiceRegistrations.Cors;
using InterCV.Server.Models;
using InterCV.Server.Repositories;

namespace InterCV.Server.Configuration.ServiceRegistrations;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers().AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
        });
        //TODO REMOVE TEST 
        services.AddScoped<TestRepository>();
        
        services.AddCorsSettings();
        
        services.AddDbContexts(configuration) ;
        
        services.AddEndpointsApiExplorer();
        
        services.AddSwaggerGen();
        
        return services;
    }
}