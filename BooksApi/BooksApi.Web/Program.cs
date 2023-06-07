using BooksApi.Db;
using BooksApi.Logic.BooksService;
using BooksApi.Logic.CategoriesService;
using BooksApi.Web.Utilities;
using BooksApi.WebDb.BooksRepository;
using BooksApi.WebDb.CategoriesRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBooksService, BooksService>();
builder.Services.AddScoped<IBooksRepository, BooksRepository>();

builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddDbContext<BooksContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Library");

    options.UseSqlServer(connectionString);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("devCors", policyBuilder =>
    {
        policyBuilder.AllowAnyOrigin();
        policyBuilder.AllowAnyMethod();
        policyBuilder.AllowAnyHeader();
    });
});

var app = builder.Build();

using var scope = app.Services.CreateScope();

var context = scope.ServiceProvider.GetService<BooksContext>();

context!.Database.EnsureCreated();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseCors("devCors");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program { }
