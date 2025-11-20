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
        //TODO Currently prints ID's, remove it
        var result = await users.GetCurrentUserAsync();
        if (result == null)
            return Unauthorized();
        
        return Ok(result);
    }
    
    [Authorize]
    [HttpGet("debug")]
    public async Task<IActionResult> Debug()
    {
        var user = HttpContext.User;

        var claims = user.Claims
            .Select(c => new { c.Type, c.Value })
            .ToList();

        var idToken = await HttpContext.GetTokenAsync("id_token");
        var accessToken = await HttpContext.GetTokenAsync("access_token");

        return Ok(new
        {
            Claims = claims,
            IdentityName = user.Identity?.Name,
            AuthenticationType = user.Identity?.AuthenticationType,
            IsAuthenticated = user.Identity?.IsAuthenticated,
            IdToken = idToken,
            AccessToken = accessToken
        });
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