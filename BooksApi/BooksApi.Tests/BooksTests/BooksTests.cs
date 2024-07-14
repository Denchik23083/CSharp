using BooksApi.Db.Entities;
using BooksApi.Logic.BooksService;
using BooksApi.WebDb.BooksRepository;
using Moq;
using Xunit;

namespace BooksApi.Tests.BooksTests
{
    public class BooksTests
    {
        private readonly Mock<IBooksRepository> _repository;

        public BooksTests()
        {
            _repository = new Mock<IBooksRepository>();
        }

        [Fact]
        public async Task Get_All_Books()
        {
            var books = new List<Book>
            {
                new()
                {
                    Id = 1,
                    Title = "Гарри Поттер и философский камень",
                    Author = "Джоан Роулинг",
                    PagesCount = 500,
                    PublishDate = new DateTime(1997, 06, 26),
                    CategoryId = 1
                },
                new()
                {
                    Id = 2,
                    Title = "Гарри Поттер и Тайная комната",
                    Author = "Джоан Роулинг",
                    PagesCount = 450,
                    PublishDate = new DateTime(1998, 07, 02),
                    CategoryId = 2
                },
                new()
                {
                    Id = 3,
                    Title = "Гарри Поттер и узник Азкабана",
                    Author = "Джоан Роулинг",
                    PagesCount = 600,
                    PublishDate = new DateTime(1999, 07, 08),
                    CategoryId = 1
                },
                new()
                {
                    Id = 4,
                    Title = "Гарри Поттер и Кубок огня",
                    Author = "Джоан Роулинг",
                    PagesCount = 700,
                    PublishDate = new DateTime(2000, 07, 08),
                    CategoryId = 2
                }
            };

            _repository.Setup(_ => _.GetAll())
                .ReturnsAsync(books);

            IBooksService service = new BooksService(_repository.Object);

            var result = await service.GetAll();

            _repository.Verify(_ => _.GetAll(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(books.Count, result.Count());
        }

        [Fact]
        public async Task Get_Book()
        {
            const int expectedId = 1;

            var book = new Book
            {
                Id = expectedId,
                Title = "Гарри Поттер и философский камень",
                Author = "Джоан Роулинг",
                PagesCount = 500,
                PublishDate = new DateTime(1997, 06, 26),
                CategoryId = 1
            };

            _repository.Setup(_ => _.Get(expectedId))
                .ReturnsAsync(book);

            IBooksService service = new BooksService(_repository.Object);

            var result = await service.Get(expectedId);

            _repository.Verify(_ => _.Get(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(book.Id, result.Id);
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

            _repository.Setup(_ => _.Create(newBook));

            IBooksService service = new BooksService(_repository.Object);

            await service.Create(newBook);

            _repository.Verify(_ => _.Create(newBook),
                Times.Once);
        }

        [Fact]
        public async Task Update_Book()
        {
            const int expectedId = 1;

            var book = new Book
            {
                Id = expectedId,
                Title = "Гарри Поттер и философский камень",
                Author = "Джоан Роулинг",
                PagesCount = 500,
                PublishDate = new DateTime(1997, 06, 26),
                CategoryId = 1
            };

            var updatedBook = new Book
            {
                Title = "updatedTitle",
                Author = "updatedAuthor",
                PagesCount = 200,
                PublishDate = DateTime.Now.AddYears(-2),
                CategoryId = 1
            };

            _repository.Setup(_ => _.Get(expectedId))
                .ReturnsAsync(book);

            _repository.Setup(_ => _.Update(book));

            IBooksService service = new BooksService(_repository.Object);

            await service.Update(updatedBook, expectedId);

            _repository.Verify(_ => _.Get(expectedId),
                Times.Once);

            _repository.Verify(_ => _.Update(book),
                Times.Once);
        }

        [Fact]
        public async Task Delete_Book()
        {
            const int expectedId = 1;

            var book = new Book
            {
                Id = expectedId,
                Title = "Гарри Поттер и философский камень",
                Author = "Джоан Роулинг",
                PagesCount = 500,
                PublishDate = new DateTime(1997, 06, 26),
                CategoryId = 1
            };

            _repository.Setup(_ => _.Get(expectedId))
                .ReturnsAsync(book);

            _repository.Setup(_ => _.Delete(book));

            IBooksService service = new BooksService(_repository.Object);

            await service.Delete(expectedId);

            _repository.Verify(_ => _.Get(expectedId),
                Times.Once);

            _repository.Verify(_ => _.Delete(book),
                Times.Once);
        }
    }
}