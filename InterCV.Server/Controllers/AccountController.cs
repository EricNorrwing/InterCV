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
        var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
            .WithRedirectUri(config["Authentication:CallbackUrl"]) 
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
        return View(new
        {
            Name = User.Identity.Name,
            EmailAddress = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
            ProfileImage = User.Claims.FirstOrDefault(c => c.Type == "picture")?.Value
        });
    }

    [Authorize]
    [HttpGet("logout")]
    public async Task Logout()
    {
        var authenticationProperties = new LogoutAuthenticationPropertiesBuilder()
            .WithRedirectUri(config["Authentication:CallbackUrl"])
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