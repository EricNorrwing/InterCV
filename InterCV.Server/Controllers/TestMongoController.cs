using InterCV.Server.Configuration;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace InterCV.Server.Controllers;
//TODO DELETE ME, CLEAN UP THE DB SETTINGS NEXT
[ApiController]
[Route("api/[controller]")]
public class TestMongoController(MongoDbConfig mongoConfig) : ControllerBase
{
    
    [HttpGet]
    public IActionResult Get()
    {
        var db = mongoConfig.GetDatabase("InterCV");
        var collection = db.GetCollection<dynamic>("sampleCV");

        var item = collection.Find("{}").FirstOrDefault();

        return Ok(item);
    }
}
