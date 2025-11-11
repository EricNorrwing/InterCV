using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Services;
using Microsoft.AspNetCore.Mvc;


namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(CvService cvService, SettingsProvider settingsProvider) : ControllerBase
{
    
    [HttpGet("sample-cv")]
    public async Task<IActionResult> GetSampleCv()
    {
        Console.WriteLine("Fetching sample Cv with ID: " + settingsProvider.ExposeSettings("SampleCvId"));
        var dto = await cvService.GetSampleCvAsync();
        if (dto == null) return NotFound("Sample CV not found.");

        return Ok(dto);
    }
    
    
}