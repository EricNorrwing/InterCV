using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.DbContextsConfiguration;
using InterCV.Server.Configuration.ServiceRegistrations.Cors;
using InterCV.Server.Repositories;
using InterCV.Server.Services;

namespace InterCV.Server.Configuration.ServiceRegistrations;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        //TODO research
        services.AddControllers().AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
        });
        
        services.AddCorsSettings();
        
        services.AddDbContexts(configuration) ;
        
        services.AddSingleton<SettingsProvider>();
        
        services.AddScoped<CvService>();
        services.AddScoped<UserService>();
        
        services.AddScoped<CvRepository>();
        services.AddScoped<UserRepository>();
            
            
        services.AddEndpointsApiExplorer();
        
        services.AddSwaggerGen();
        
        return services;
    }
}