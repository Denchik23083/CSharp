using BooksApi.Db.Entities;
using System.Net.Http.Json;
using System.Net;
using System.Text.Json;
using Xunit;
using BooksApi.Tests.ApiConfiguration;

namespace BooksApi.Tests.CategoriesTests
{
    public class CategoriesTests : ApiTestBase
    {
        [Fact]
        public async Task Get_All_Categories()
        {
            const int expectedCount = 2;

            var body = await HttpClient.GetStringAsync("api/Categories");

            var categories = JsonSerializer.Deserialize<IEnumerable<Category>>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (categories is null)
            {
                throw new ArgumentException("Not found");
            }

            Assert.NotNull(categories);
            Assert.Equal(expectedCount, categories.Count());
        }

        [Fact]
        public async Task Get_Category()
        {
            const int expectedId = 1;

            var body = await HttpClient.GetStringAsync($"api/Categories/id?id={expectedId}");

            var category = JsonSerializer.Deserialize<Category>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (category is null)
            {
                throw new ArgumentException("Not found");
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

            var response = await HttpClient.PostAsync("api/Categories", content);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Update_Category()
        {
            const int expectedId = 4;

            var updatedCategory = new Category
            {
                Description = "updatedDescription"
            };

            var content = JsonContent.Create(updatedCategory);

            var response = await HttpClient.PutAsync($"api/Categories/id?id={expectedId}", content);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Delete_Category()
        {
            const int expectedId = 4;

            var response = await HttpClient.DeleteAsync($"api/Categories/id?id={expectedId}");

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
