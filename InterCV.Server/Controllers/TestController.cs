using InterCV.Server.Configuration.DbContextsConfiguration.DBContext;
using InterCV.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterCV.Server.Controllers;


[ApiController]
[Route("api/test")]
public class TestController(TestRepository testRepository, InterCvDbContext dbContext) : ControllerBase
{
    [HttpGet("first-cv")]
    public async Task<IActionResult> GetFirstCv()
    {
        var userId = Guid.Parse("E921C461-F6D3-4408-2187-08DE1D2F9552");
        var cv = await testRepository.GetAllCvsForUserAsync(userId);

        if (cv == null) return NotFound("No CV found for this user");

        return Ok(cv);
    }
    
    [HttpGet("experiences")]
    public async Task<IActionResult> GetExperiences()
    {
        var userId = Guid.Parse("E921C461-F6D3-4408-2187-08DE1D2F9552"); // test user
        var experiences = await testRepository.GetFirstCvForUserAsync(userId);

        return Ok(experiences);
    }
    
    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetUserWithProfile(string userId)
    {
        if (!Guid.TryParse(userId, out var parsedUserId))
            return BadRequest("Invalid GUID.");

        var user = await dbContext.Users
            .AsNoTracking() // avoids tracking issues
            .Include(u => u.Profile) // include only the profile
            .Where(u => u.Id == parsedUserId)
            .Select(u => new
            {
                u.Id,
                Profile = u.Profile != null
                    ? new
                    {
                        u.Profile.FirstName,
                        u.Profile.LastName,
                        u.Profile.Phone,
                        u.Profile.LinkedInUrl,
                        u.Profile.DefaultTitle
                    }
                    : null
            })
            .FirstOrDefaultAsync();

        if (user == null) return NotFound("User not found.");

        return Ok(user);
    }
    
    [HttpGet("debug-all-users")]
    public async Task<IActionResult> DebugAllUsers()
    {
        var users = await dbContext.Users
            .AsNoTracking()
            .Include(u => u.Profile)
            .Select(u => new { u.Id, ProfileName = u.Profile != null ? u.Profile.FirstName + " " + u.Profile.LastName : null })
            .ToListAsync();

        return Ok(users);
    }

}