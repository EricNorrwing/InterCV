using InterCV.Server.Configuration;
using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.ServiceRegistrations;
using InterCV.Server.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddConfigurations(builder.Environment);

builder.Services.AddServices(builder.Configuration);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//TODO earlier temp cors setup
app.UseCors("AllowFrontendDev");
//TODO
var connectionString = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTION_STRING");
Console.WriteLine(connectionString);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
