using InterCV.Server.Models;
using InterCV.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

public interface ICvController
{
    public Task<IActionResult> GetSampleCv();
    public Task<IActionResult> GetCv(int id);
}

[ApiController]
[Route("[controller]")]
public class CvController(ICvService cvService) : ControllerBase, ICvController
{
    
    [HttpGet("sample-cv")]
    public async Task<IActionResult> GetSampleCv()
    {
        Console.WriteLine("Fetching sample CV: " );
        var cv = SampleCv.GetSampleCv();

        return Ok(cv);
    }
    
    [HttpGet("cv")]
    public async Task<IActionResult> GetCv(int id)
    {
        Console.WriteLine("Fetching Cv with ID: " );
        var dto = await cvService.GetCvAsync();
        if (dto == null) return NotFound("Sample CV not found.");

        return Ok(dto);
    }
    
    
}