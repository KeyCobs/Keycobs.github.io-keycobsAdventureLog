using KeycobsGamingAdventures.Models;
using KeycobsGamingAdventures.Repository;
using KeycobsGamingAdventures.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDbContext>(options =>
                                           options.UseSqlServer(builder.Configuration.GetConnectionString("DbContextConnection")));

builder.Services.AddScoped<IAdventureLogRepository, AdventureLogRepository>()
                .AddScoped<IEnemyRepository, EnemyRepository>()
                .AddScoped<IGameRepository, GameRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Game}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
