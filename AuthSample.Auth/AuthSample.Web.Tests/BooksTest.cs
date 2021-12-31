using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using AuthSample.Core;
using AuthSample.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Xunit;

namespace AuthSample.Web.Tests
{
    public class BooksTest : ApiTestBase
    {
        [Fact]
        public async Task GetAllBooks()
        {
            AddTokenWithPermissions(new List<PermissionType>
            {
                PermissionType.ReadBooks
            });

            var jsonString = await _client.GetStringAsync("api/Books");
            var books = JsonConvert.DeserializeObject<List<BookModel>>(jsonString);

            Assert.Equal(2, books.Count);
        }

        [Fact]
        public async Task GetBookById()
        {
            AddTokenWithPermissions(new List<PermissionType>
            {
                PermissionType.ReadBooks
            });
            
            var expectedId = 1;
            var jsonString = await _client.GetStringAsync($"api/Books/{expectedId}");
            var book = JsonConvert.DeserializeObject<BookModel>(jsonString);

            Assert.NotNull(book);
            Assert.Equal(expectedId, book.Id);
        }

        [Fact]
        public async Task CreateBook()
        {
            AddTokenWithPermissions(new List<PermissionType>
            {
                PermissionType.EditBooks
            });

            var book = new BookModel
            {
                Id = 2,
                Title = "Капитан Джек",
                Author = "Дж. Роуль",
                PagesCount = 400,
                PublishDate = new DateTime(2000, 06, 05)
            };

            var json = JsonConvert.SerializeObject(book);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("api/Books", content);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task UpdateBook()
        {
            AddTokenWithPermissions(new List<PermissionType>
            {
                PermissionType.EditBooks
            });

            var book = new BookModel
            {
                Title = "updateКапитан Джек",
                Author = "updateДж. Роуль2",
                PagesCount = 500,
                PublishDate = new DateTime(2001, 09, 25)
            };

            var json = JsonConvert.SerializeObject(book);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync("api/Books/1", content);

            Assert.True(response.IsSuccessStatusCode);
        }

        [Fact]
        public async Task DeleteBook()
        {
            AddTokenWithPermissions(new List<PermissionType>
            {
                PermissionType.EditBooks
            });

            var response = await _client.DeleteAsync("api/Books/2");

            Assert.True(response.IsSuccessStatusCode);
        }
    }
}
