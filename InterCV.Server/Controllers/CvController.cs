using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class CvController(InterCvDbContext dbContext) : ControllerBase
{
    [HttpGet("sampleCv")]
    public ActionResult<Cv> GetSampleCv()
    {
        var cv = SampleCv.GetSampleCv();
        return Ok(cv);
    }
    
    [HttpPost("sample")]
    public async Task<IActionResult> AddSampleCv()
    {
        var sampleCv = SampleCv.GetSampleCv();

        // Add CV (along with user, experiences, educations, tags, achievements, references)
        dbContext.Cvs.Add(sampleCv);

        await dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCvById), new { id = sampleCv.Id }, sampleCv);
    }
    
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
    public async Task<IActionResult> ViewSampleCv()
    {
        var cv = await dbContext.Cvs
            .Include(c => c.User)
            .ThenInclude(u => u.Profile)
            .Include(c => c.Experiences)
            .ThenInclude(ce => ce.Experience)
            .ThenInclude(e => e.Achievements)
            .Include(c => c.Experiences)
            .ThenInclude(ce => ce.Experience)
            .ThenInclude(e => e.References)
            .Include(c => c.Educations)
            .ThenInclude(ce => ce.Education)
            .Include(c => c.Tags)
            .ThenInclude(ct => ct.Tag)
            .FirstOrDefaultAsync();

        if (cv == null) return NotFound();

        return Ok(cv);
    }

    
}