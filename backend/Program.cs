using QuickDish.Extensions;

var builder = WebApplication.CreateBuilder();

builder.Services.AddServices();

builder.Services.AddCorsFrontend();

var app = builder.Build();

app.AddSwagger();
app.UseCors("AllowFrontend");

app.HealthCheck();

app.Run();