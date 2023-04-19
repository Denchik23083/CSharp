using BooksApi.Db.Entities;
using BooksApi.Logic.BooksService;
using BooksApi.WebDb.BooksRepository;
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
            _books
                .Setup(_ => _.GetAll())
                .ReturnsAsync(new List<Book>());

            var service = new BooksService(_books.Object);

            var books = await service.GetAll();

            Assert.NotNull(books);
        }
    }
}