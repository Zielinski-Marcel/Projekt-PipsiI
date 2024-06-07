using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;
using PoroCounter2.Controllers.Endpoints;
using PoroCounter2.Data;
using PoroCounter2.Services;
using Serilog;
using System.Globalization;
using PoroCounter2;

var builder = WebApplication.CreateBuilder(args);

// Lokalization
builder.Services.AddMvc().AddMvcLocalization(LanguageViewLocationExpanderFormat.Suffix);
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options=>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("pl")
    };
    options.DefaultRequestCulture=new ("en");
    options.SupportedCultures=supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders = new List<IRequestCultureProvider>
    {
        new QueryStringRequestCultureProvider(),
        new CookieRequestCultureProvider()
    };
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Logs
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog(); 

// DataBase
builder.Services.AddDbContext<DB>(options =>
{
    options.UseSqlServer("Server=DESKTOP-7UAFIFA\\SQLEXPRESS;Database=PPSIDB2;Trusted_Connection=True;TrustServerCertificate=True;");//databaseconection
});

// Mailing
builder.Services.AddTransient<PoroCounter2.IEmailSender, EmailSender>();

//Cache
builder.Services.AddMemoryCache();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DB>();

builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// LolAPIService
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


app.UseRequestLocalization();

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