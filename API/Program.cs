using Persistence; // Add this for DataContext
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register DataContext with dependency injection
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite("Data Source=Blogbox.db")); // Ensure the connection string matches your setup

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Development-specific configurations (if any)
}

// Uncomment if HTTPS redirection is needed
// app.UseHttpsRedirection();

app.MapControllers();

app.Run();
