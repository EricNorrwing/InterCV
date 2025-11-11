namespace InterCV.Server.Configuration.Configurations;

public static class ConfigurationRegistration
{
    public static IConfigurationBuilder AddConfigurations(this IConfigurationBuilder configuration, IHostEnvironment environment)
    {
        configuration
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
        
        if (environment.IsDevelopment())
        {
            configuration.AddUserSecrets<Program>(optional: true);
        }
        
        configuration.AddEnvironmentVariables();
        
        return configuration;
    }
}