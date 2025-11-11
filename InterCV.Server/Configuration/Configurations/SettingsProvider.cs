namespace InterCV.Server.Configuration.Configurations;

public class SettingsProvider
{
    private readonly IConfiguration _configuration;

    public SettingsProvider(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string? ExposeSettings(string key)
    {
        var value = _configuration[$"Settings:{key}"];
        if (string.IsNullOrEmpty(value))
        {
            Console.WriteLine($"Settings key '{key}' not found or empty");
            return null;
        }

        return value;
    }
}