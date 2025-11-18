using System.Security.Claims;
using Auth0.AspNetCore.Authentication;
using InterCV.Server.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InterCV.Server.Controllers;

[Route("account")] 
public class AccountController(IUserService users) : Controller
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
    public async Task<IActionResult> Profile()
    {
        var result = await users.GetCurrentUserAsync();
        if (result == null)
            return Unauthorized();
        
        return Ok(result);
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