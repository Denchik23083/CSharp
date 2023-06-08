namespace BooksApi.Tests.ApiConfiguration
{
    public class ApiTestBase : ApiFactory
    {
        protected readonly HttpClient HttpClient;

        public ApiTestBase()
        {
            var app = new ApiFactory();
            HttpClient = app.CreateClient();
        }
    }
}
