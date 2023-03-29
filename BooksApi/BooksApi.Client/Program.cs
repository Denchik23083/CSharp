using System.Text.Json;
using BooksApi.Db.Entities;

namespace BooksApi.Client
{
    public class Program
    {
        private static readonly HttpClient HttpClient = new();

        public static async Task Main(string[] args)
        {
            var body = await GetData("https://localhost:5001/api/Categories");

            var category = JsonSerializer.Deserialize<IEnumerable<Category>>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private static async Task<string> GetData(string requestUrl)
        {
            var result = await HttpClient.GetAsync(requestUrl);

            var body = await result.Content.ReadAsStringAsync();

            if (!result.IsSuccessStatusCode)
            {
                throw new ApplicationException(body);
            }

            return body;
        }
    }
}