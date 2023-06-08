using BooksApi.Logic.BooksService;
using BooksApi.Logic.CategoriesService;
using BooksApi.WebDb.BooksRepository;
using BooksApi.WebDb.CategoriesRepository;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BooksApi.Tests.ApiConfiguration
{
    public class ApiFactory : WebApplicationFactory<Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddScoped<IBooksService, BooksService>();
                services.AddScoped<IBooksRepository, BooksRepository>();

                services.AddScoped<ICategoriesService, CategoriesService>();
                services.AddScoped<ICategoriesRepository, CategoriesRepository>();
            });

            return base.CreateHost(builder);
        }
    }
}
