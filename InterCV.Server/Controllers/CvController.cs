using InterCV.Server.Models;
using InterCV.Server.Models.CvModels;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(SampleCv sampleCv): Controller
{
    
    //TODO just look at it it needs typing and then you can remove this. Also async
    [HttpGet("sampleCv")]
    public Task<ActionResult<CvModel>> GetSampleCv()
    {
        var cv = sampleCv.GetSampleCv();
        
        return Task.FromResult<ActionResult<CvModel>>(Ok(cv));
    }

    
}

