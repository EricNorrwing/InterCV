using InterCV.Server.Configuration;
using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.ServiceRegistrations;
using InterCV.Server.Models;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddConfigurations(builder.Environment);

builder.Services.AddServices(builder.Configuration);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//TODO earlier temp cors setup
app.UseCors("AllowFrontendDev");

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
