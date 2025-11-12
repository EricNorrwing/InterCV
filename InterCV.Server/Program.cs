using InterCV.Server.Configuration.Configurations;
using InterCV.Server.Configuration.ServiceRegistrations;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddConfigurations(builder.Environment);

builder.Services.AddServices(builder.Configuration);

var app = builder.Build();

app.UseAppConfiguration();

app.Run();
