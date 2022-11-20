using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using BookApi.Db;
using BookApi.Logic;
using BookApi.WebDb;
using BooksApi.Web.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IBookRepository, BookRepository>();

            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BooksApi.Web", Version = "v1" });
            });

            services.AddDbContext<BookContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("Library");

                options.UseSqlServer(connectionString);
            });

            services.AddDbContext<TestsBookContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("TestsLibrary");

                options.UseSqlServer(connectionString);
            });

            services.AddCors(options =>
            {
                options.AddPolicy("devCors", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BooksApi.Web v1"));

                app.UseCors("devCors");
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            EnsureDbCreated(app);
            EnsureTestsDbCreated(app);
        }

        public void EnsureDbCreated(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            
            using var scope = scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<BookContext>();

            context!.Database.EnsureCreated();
        }

        public void EnsureTestsDbCreated(IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();

            using var scope = scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetService<TestsBookContext>();

            context!.Database.EnsureCreated();
        }
    }
}
