using QuickDish.Extensions;

var builder = WebApplication.CreateBuilder();

builder.Services.AddServices();
builder.Services.AddControllers();

builder.Services.AddCorsFrontend();

var app = builder.Build();

app.AddSwagger();
app.UseCors("AllowFrontend");

app.MapControllers();

app.Run();