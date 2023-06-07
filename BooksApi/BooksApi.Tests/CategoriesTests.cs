using BooksApi.Db.Entities;
using System.Net.Http.Json;
using System.Net;
using System.Text.Json;
using Xunit;

namespace BooksApi.Tests
{
    public class CategoriesTests : ApiTestBase
    {
        private readonly HttpClient _httpClient;

        public CategoriesTests()
        {
            var app = new ApiTestBase();
            _httpClient = app.CreateClient();
        }

        [Fact]
        public async Task Get_All_Categories()
        {
            var expectedCount = 2;

            var body = await GetData("api/Categories");

            var categories = JsonSerializer.Deserialize<IEnumerable<Category>>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (categories is null)
            {
                throw new ArgumentNullException(nameof(categories));
            }

            Assert.NotNull(categories);
            Assert.Equal(expectedCount, categories.Count());
        }

        [Fact]
        public async Task Get_Category()
        {
            var expectedId = 1;

            var body = await GetData($"api/Categories/id?id={expectedId}");

            var category = JsonSerializer.Deserialize<Category>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (category is null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            Assert.NotNull(category);
            Assert.Equal(expectedId, category.Id);
        }

        [Fact]
        public async Task Create_Category()
        {
            var newCategory = new Category
            {
                Description = "newDescription",
            };

            var content = JsonContent.Create(newCategory);

            var response = await _httpClient.PostAsync("api/Categories", content);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Update_Category()
        {
            var expectedId = 3;

            var updatedCategory = new Category
            {
                Description = "updatedDescription"
            };

            var content = JsonContent.Create(updatedCategory);

            var response = await _httpClient.PutAsync($"api/Categories/id?id={expectedId}", content);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Delete_Category()
        {
            var expectedId = 3;

            var response = await _httpClient.DeleteAsync($"api/Categories/id?id={expectedId}");

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
