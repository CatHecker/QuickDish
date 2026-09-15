using QuickDish.Clients;
using QuickDish.Services;

namespace QuickDish.Extensions;

public static class HostingExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        
        services.AddHttpClient<IMealDbClient, MealDbClient>(client =>
        {
            client.BaseAddress = new Uri("https://www.themealdb.com/api/json/v1/1/");
        });
        
        services.AddScoped<IRecipeService, RecipeService>();
        
        services.AddSwaggerGen();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        
        return services;
    }

    public static IServiceCollection AddCorsFrontend(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontend", policy =>
            {
                policy.WithOrigins("http://localhost:5173")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
        return services;
    }
    
    public static WebApplication AddSwagger(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        return app;
    }
}