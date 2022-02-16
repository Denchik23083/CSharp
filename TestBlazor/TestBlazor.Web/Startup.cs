using Blazor.Db;
using Blazor.Db.Entities.TestModel1;
using Blazor.Logic.BooksService;
using Blazor.Logic.TestService;
using Blazor.WebDb.BooksRepository;
using Blazor.WebDb.TestRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TestBlazor.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IGameImageService, GameImageService>();
            services.AddScoped<IGameImageRepository, GameImageRepository>();
            services.AddScoped<IGenreImageService, GenreImageService>();
            services.AddScoped<IGenreImageRepository, GenreImageRepository>();

            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientService>();
            services.AddScoped<ScopedService>();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<BlazorContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("Blazor");

                options.UseSqlServer(connectionString);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
