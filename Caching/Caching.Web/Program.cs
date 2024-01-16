using Caching.Db;
using Caching.Logic;
using Caching.Web.Utilities;
using Caching.WebDb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICachingService, CachingService>();
builder.Services.AddScoped<ICachingRepository, CachingRepository>();

builder.Services.AddDbContext<CachingContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Caching");
    options.UseSqlServer(connectionString);
});

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

builder.Services.AddMemoryCache();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
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

app.Run();
