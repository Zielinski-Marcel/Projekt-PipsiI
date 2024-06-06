using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PoroCounter2.Controllers.Endpoints;
using PoroCounter2.Data;
using PoroCounter2.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog(); // Dodaj Serilog do HostBuilder

// Add services to the container.
builder.Services.AddDbContext<DB>(options =>
{
    options.UseSqlServer("Server=DESKTOP-7UAFIFA\\SQLEXPRESS;Database=PPSIDB2;Trusted_Connection=True;TrustServerCertificate=True;");
});

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DB>();

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Rejestracja LolAPIService
builder.Services.AddTransient<LolAPIService>();
builder.Services.AddHttpClient<LolAPIService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "LolStatus",
    pattern: "LolStatus/Index",
    defaults: new { controller = "LolStatus", action = "Index" });

app.MapRazorPages();

app.MapChampionsAtributeEndpoints();
app.MapChampionCounterEndpoints();

app.Run();