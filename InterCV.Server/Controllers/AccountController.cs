using System.Security.Claims;
using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

[Route("account")] 
public class AccountController(IConfiguration config) : Controller
{
    [HttpGet("login")] 
    public async Task Login()
    {
        //TODO update to gather other information we might need later for example to link accounts.
        var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
            .WithRedirectUri("https://localhost:60965/en/home")
            .WithScope("openid profile email")
            .Build();

        await HttpContext.ChallengeAsync(
            Auth0Constants.AuthenticationScheme,
            authenticationProperties
        );
    }

    [Authorize]
    [HttpGet("profile")]
    public IActionResult Profile()
    {
        // TODO just checking custom claims, AI built this horrifying item
        var allClaims = User.Claims
            .Select(c => new 
            { 
                Type = c.Type, 
                Value = c.Value 
            })
            .ToList();
        
        var rolesJson = User.Claims.FirstOrDefault(c => c.Type == "https://intercv.com/roles")?.Value;
        string[] roles = Array.Empty<string>();
        if (!string.IsNullOrEmpty(rolesJson))
        {
            try
            {
                roles = System.Text.Json.JsonSerializer.Deserialize<string[]>(rolesJson);
            }
            catch
            {
                roles = new string[] { rolesJson };
            }
        }

        var profile = new
        {
            Name = User.Identity?.Name ?? "",
            Email = User.FindFirstValue(ClaimTypes.Email) ?? "",
            ProfileImage = User.Claims.FirstOrDefault(c => c.Type == "picture")?.Value ?? "",
            Roles = roles,
            Claims = allClaims
        };

        return Ok(profile);
    }

    [Authorize]
    [HttpGet("logout")]
    public async Task Logout()
    {
        var authenticationProperties = new LogoutAuthenticationPropertiesBuilder()
            .WithRedirectUri("https://localhost:60965/en/home")
            .Build();

        await HttpContext.SignOutAsync(
            Auth0Constants.AuthenticationScheme,
            authenticationProperties
        );

        await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme
        );
    }
    
}