using FileUploadApp.Db;
using FileUploadApp.Logic;
using FileUploadApp.WebDb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FileUploadContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("FileUpload");

    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IFileUploadService, FileUploadService>();
builder.Services.AddScoped<IFileUploadRepository, FileUploadRepository>();

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
