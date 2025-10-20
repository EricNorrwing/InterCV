using InterCV.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(SampleCv sampleCv)
{
    
    //TODO just look at it it needs typing and then you can remove this. Also async
    [HttpGet(Name = "GetSampleCv")]
    public object GetSampleCv()
    {
        return sampleCv.GetSampleCv().Value!;
    }
}
