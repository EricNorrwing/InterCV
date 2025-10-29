using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace InterCV.Server.Configuration;

public class MongoDbConfig
{
    private readonly IMongoClient _client;

    public MongoDbConfig(IConfiguration configuration)
    {
        var connectionUri = configuration.GetConnectionString("MongoDbUri");

        if (string.IsNullOrEmpty(connectionUri))
            throw new Exception("MongoDB connection string is missing in appsettings.json");

        var settings = MongoClientSettings.FromConnectionString(connectionUri);
        settings.ServerApi = new ServerApi(ServerApiVersion.V1);

        _client = new MongoClient(settings);

        try
        {
            var result = _client
                .GetDatabase("InterCV")
                .RunCommand<BsonDocument>(new BsonDocument("ping", 1));

            Console.WriteLine("✅ Successfully connected to MongoDB!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ MongoDB connection failed:");
            Console.WriteLine(ex);
        }
    }

    public IMongoDatabase GetDatabase(string name) =>
        _client.GetDatabase(name);
}