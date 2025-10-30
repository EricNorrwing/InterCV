using Microsoft.AspNetCore.Cors.Infrastructure;

namespace InterCV.Server.Configuration.ServiceRegistrations;

public static class CorsSettings
{
    public static IServiceCollection AddCorsSettings(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontendDev", policy =>
            {
                policy
                    .WithOrigins("https://localhost:60965")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        return services;
    }
}