using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazoPageMovie.Data;
using RazoPageMovie.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazoPageMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazoPageMovieContext") ?? throw new InvalidOperationException("Connection string 'RazoPageMovieContext' not found.")));

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
