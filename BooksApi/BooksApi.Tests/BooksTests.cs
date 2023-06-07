using System.Text.Json;
using BooksApi.Db.Entities;
using Xunit;

namespace BooksApi.Tests
{
    public class BooksTests : ApiTestBase
    {
        private readonly HttpClient _httpClient;

        public BooksTests()
        {
            var app = new ApiTestBase();
            _httpClient = app.CreateClient();
        }

        [Fact]
        public async Task Get_All_Books()
        {
            var result = await _httpClient.GetAsync("/api/Books");

            var body = await result.Content.ReadAsStringAsync();

            if (!result.IsSuccessStatusCode)
            {
                throw new ApplicationException(body);
            }

            var books = JsonSerializer.Deserialize<IEnumerable<Book>>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            Assert.NotNull(books);
            Assert.Equal(3, books!.Count());
        }
    }
}