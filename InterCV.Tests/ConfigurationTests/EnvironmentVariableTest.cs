using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;

namespace InterCV.Tests.ConfigurationTests;

public class EnvironmentVariableTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public EnvironmentVariableTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void MongoDbUri_Should_BeLoaded_FromUserSecrets()
    {
        var config = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddUserSecrets("32088852-2b6b-49ee-a777-5569447d312e") // <--- load secrets from server project
            .Build();

        var mongoUri = config.GetConnectionString("MongoDbUri");

        Assert.False(string.IsNullOrEmpty(mongoUri), "MongoDbUri is not set!");
        _testOutputHelper.WriteLine($"MongoDbUri loaded: {mongoUri.Substring(0, 10)}*****");
    }
}