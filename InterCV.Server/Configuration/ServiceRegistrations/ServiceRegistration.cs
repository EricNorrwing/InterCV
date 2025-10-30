using InterCV.Server.Models;

namespace InterCV.Server.Configuration.ServiceRegistrations;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        
        
        //TODO adding sample CV remove later
        services.AddSingleton<SampleCv>();
        //TODO Update DB Config
        services.AddSingleton<MongoDbConfig>();
        
        services.AddCorsSettings();
        
        services.AddDbContexts();
        
        services.AddEndpointsApiExplorer();
        
        services.AddSwaggerGen();
        
        return services;
    }
}