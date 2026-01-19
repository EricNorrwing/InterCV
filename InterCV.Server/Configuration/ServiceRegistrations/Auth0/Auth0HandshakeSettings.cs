using Auth0.AspNetCore.Authentication;
using InterCV.Server.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace InterCV.Server.Configuration.ServiceRegistrations.Auth0;

public static class Auth0HandshakeSettings
{
    //TODO Verify and run tests
    public static IServiceCollection AddAuth0Handshake(this IServiceCollection services)
    {
        services.Configure<OpenIdConnectOptions>(Auth0Constants.AuthenticationScheme, opts =>
        {
            opts.Events = new OpenIdConnectEvents
            {
                OnAuthorizationCodeReceived = async ctx =>
                {
                    var userService = ctx.HttpContext.RequestServices.GetRequiredService<IUserService>();
                    await userService.AutoCreateUserIfNewUserAsync();
                }
            };
        });

        return services;
    }
}