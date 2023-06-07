using BooksApi.Db.Entities;
using System.Net.Http.Json;
using System.Net;
using System.Text.Json;
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
            var expectedCount = 4;

            var body = await GetData("api/Books");

            var books = JsonSerializer.Deserialize<IEnumerable<Book>>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (books is null)
            {
                throw new ArgumentNullException(nameof(books));
            }
            
            Assert.NotNull(books);
            Assert.Equal(expectedCount, books.Count());
        }

        [Fact]
        public async Task Get_Book()
        {
            var expectedId = 1;

            var body = await GetData($"api/Books/id?id={expectedId}");

            var book = JsonSerializer.Deserialize<Book>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (book is null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            Assert.NotNull(book);
            Assert.Equal(expectedId, book.Id);
        }

        [Fact]
        public async Task Create_Book()
        {
            var newBook = new Book
            {
                Title = "newTitle",
                Author = "newAuthor",
                PagesCount = 200,
                PublishDate = new DateTime(2001, 03, 15),
                CategoryId = 1
            };

            var content = JsonContent.Create(newBook);

            var response = await _httpClient.PostAsync("api/Books", content);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Update_Book()
        {
            var expectedId = 7;

            var updatedBook = new Book
            {
                Title = "updatedTitle",
                Author = "updatedAuthor",
                PagesCount = 200,
                PublishDate = DateTime.Now.AddYears(-2),
                CategoryId = 1
            };

            var content = JsonContent.Create(updatedBook);

            var response = await _httpClient.PutAsync($"api/Books/id?id={expectedId}", content);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Delete_Book()
        {
            var expectedId = 7;
            
            var response = await _httpClient.DeleteAsync($"api/Books/id?id={expectedId}");

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        private async Task<string> GetData(string requestUrl)
        {
            var response = await _httpClient.GetAsync(requestUrl);

            var body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(body);
            }

            return body;
        }
    }
}