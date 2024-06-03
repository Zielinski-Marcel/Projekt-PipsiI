using Microsoft.EntityFrameworkCore;
using PPSI.Nowy_folder;
using PPSI3.Controllers.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DB>(options =>
{
    options.UseSqlServer("Server=DESKTOP-7UAFIFA\\SQLEXPRESS;Database=PPSIDB2;Trusted_Connection=True;TrustServerCertificate=True;");
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapChampionsAtributeEndpoints();
app.MapChampionCounterEndpoints();

app.Run();
