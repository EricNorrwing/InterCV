using Auth0.AspNetCore.Authentication;
using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.DbContextsConfiguration;
using InterCV.Server.Configuration.ServiceRegistrations.Cors;
using InterCV.Server.Repositories;
using InterCV.Server.Services;
using Microsoft.Extensions.Options;

namespace InterCV.Server.Configuration.ServiceRegistrations;

public static class ServiceRegistration
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        
        services.AddControllers();
        services.AddSingleton<SettingsProvider>();
        
        
        //TODO proper security
        services.AddCorsSettings();

        services.AddAuth0WebAppAuthentication(options =>
        {
            options.Domain = configuration["Authentication:Domain"];
            options.ClientId = configuration["Authentication:ClientId"];
        }); 
        services.AddAuthorization();
        
        
        services.AddDbContexts(configuration) ;
        
        
        
        services.AddScoped<CvService>();
        services.AddScoped<UserService>();
        
        services.AddScoped<CvRepository>();
        services.AddScoped<UserRepository>();
            
            
        services.AddEndpointsApiExplorer();
        //TODO Remove?
        services.AddControllersWithViews();
        
        services.AddSwaggerGen();
        
        return services;
    }
}