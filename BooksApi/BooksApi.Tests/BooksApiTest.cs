using BooksApi.Db;
using BooksApi.Logic.BooksService;
using BooksApi.WebDb.BooksRepository;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace BooksApi.Tests
{
    public class BooksApiTest
    {
        private readonly Mock<IBooksRepository> _books;

        public BooksApiTest()
        {
            _books = new Mock<IBooksRepository>();
        }

        [Fact]
        public async Task GetAll()
        {
            var context = new BooksContext();

            var expectedBooks = await context.Books.ToListAsync();
            
            _books
                .Setup(_ => _.GetAll())
                .ReturnsAsync(expectedBooks);

            var service = new BooksService(_books.Object);

            var books = await service.GetAll();

            Assert.Equal(expectedBooks.Count, books.Count());
        }
    }
}