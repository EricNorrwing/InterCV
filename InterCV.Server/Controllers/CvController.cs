using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models;
using InterCV.Server.Models.DTOs.DtoMappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(InterCvDbContext dbContext) : ControllerBase
{
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCvById(Guid id)
    {
        var cv = await dbContext.Cvs
            .Include(c => c.Experiences).ThenInclude(ce => ce.Experience).ThenInclude(e => e.Achievements)
            .Include(c => c.Experiences).ThenInclude(ce => ce.Experience).ThenInclude(e => e.References)
            .Include(c => c.Educations).ThenInclude(ce => ce.Education)
            .Include(c => c.Tags).ThenInclude(ct => ct.Tag)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (cv == null) return NotFound();

        return Ok(cv);
    }
    
    
    [HttpGet("sample")]
    public IActionResult GetSampleCv()
    {
        var cv = SampleCv.GetSampleCv();
        var dto = cv.ToDto();
        return Ok(dto);
    }
    
    
}