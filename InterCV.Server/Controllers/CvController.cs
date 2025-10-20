using InterCV.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(SampleCv sampleCv): Controller
{
    /*
    //TODO just look at it it needs typing and then you can remove this. Also async
    [HttpGet(Name = "sampleCv")]
    public object GetSampleCv()
    {
        return sampleCv.GetSampleCv().Value!;
    }
    */
    
    [HttpGet("test")]
    public string GetTestValue()
    {
        return "testtest";
    }
}

