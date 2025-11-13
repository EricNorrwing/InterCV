namespace InterCV.Server.Configuration.Configurations;

public static class AppConfiguration
{
    public static WebApplication UseAppConfiguration(this WebApplication app)
    {
        app.UseDefaultFiles();
        app.UseStaticFiles();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        //TODO update CORS
        app.UseCors("AllowFrontendDev");
        
        app.UseHttpsRedirection();
        
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();
        app.MapFallbackToFile("/index.html");

        return app;
    }
}