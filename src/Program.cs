using BugStore;
using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
Configuration.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(Configuration.ConnectionString);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
