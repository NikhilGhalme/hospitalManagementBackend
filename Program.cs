using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add CORS services to the container
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()  // Allow any origin
               .AllowAnyMethod()  // Allow any HTTP method
               .AllowAnyHeader(); // Allow any HTTP header
    });
});

// Add the UserService and Controllers
builder.Services.AddSingleton<UserService>();
builder.Services.AddControllers();

var app = builder.Build();

// Enable CORS globally
app.UseCors("AllowAll");

// Map controllers
app.MapControllers();

app.Run();