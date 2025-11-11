namespace InterCV.Server.Configuration.Configurations;

public class AppSettingsReader(IConfiguration configuration)
{
    public string ExposeSettings(string key)
    {
        try
        {
            var value = configuration[$"SampleGuids:{key}"];
            return value;
        }
        catch (Exception e)
        {
            Console.WriteLine("Couldn't read config value: " + e.Message);
            return null;
        }
    }

}