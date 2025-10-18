using InterCV.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(SampleCv sampleCv)
{
    [HttpGet(Name = "GetSampleCv")]
    public IActionResult Get()
    {
        var result = sampleCv.GetSampleCv();
        return result; 
    }
}
