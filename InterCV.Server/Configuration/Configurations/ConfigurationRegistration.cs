namespace InterCV.Server.Configuration.Configurations;

public static class ConfigurationRegistration
{
    public static IConfigurationBuilder AddConfigurations(this IConfigurationBuilder configuration, IHostEnvironment environment)
    {
        configuration.AddEnvironmentVariables();
        
        
        return configuration;
    }
}