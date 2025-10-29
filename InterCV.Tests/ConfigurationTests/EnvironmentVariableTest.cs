using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;

namespace InterCV.Tests.ConfigurationTests;

public class EnvironmentVariableTest(ITestOutputHelper testOutputHelper)
{
    
    //TODO Build real tests once the configs are properly setup and the pipeline works
    [Fact]
    public void MongoDbUri_Should_BeLoaded_FromUserSecrets()
    {
        var config = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddUserSecrets("32088852-2b6b-49ee-a777-5569447d312e") 
            .Build();

        var mongoUri = config.GetConnectionString("MongoDbUri");

        Assert.False(string.IsNullOrEmpty(mongoUri), "MongoDbUri is not set!");
    }
}