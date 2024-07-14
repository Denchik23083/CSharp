using BooksApi.Db.Entities;
using BooksApi.Logic.BooksService;
using BooksApi.Logic.CategoriesService;
using BooksApi.WebDb.BooksRepository;
using BooksApi.WebDb.CategoriesRepository;
using Moq;
using System.Runtime.CompilerServices;
using Xunit;

namespace BooksApi.Tests.CategoriesTests
{
    public class CategoriesTests
    {
        private readonly Mock<ICategoriesRepository> _repository;

        public CategoriesTests()
        {
            _repository = new Mock<ICategoriesRepository>();
        }

        [Fact]
        public async Task Get_All_Categories()
        {
            var categories = new List<Category>
            {
                new()
                {
                    Id = 1,
                    Description = "First Category"
                },
                new()
                {
                    Id = 2,
                    Description = "Second Category"
                }
            };

            _repository.Setup(_ => _.GetAll())
                .ReturnsAsync(categories);

            ICategoriesService service = new CategoriesService(_repository.Object);

            var result = await service.GetAll();

            _repository.Verify(_ => _.GetAll(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(categories.Count, result.Count());

        }

        [Fact]
        public async Task Get_Category()
        {
            const int expectedId = 1;

            var category = new Category
            {
                Id = expectedId,
                Description = "First Category"
            };

            _repository.Setup(_ => _.Get(expectedId))
                .ReturnsAsync(category);

            ICategoriesService service = new CategoriesService(_repository.Object);

            var result = await service.Get(expectedId);

            _repository.Verify(_ => _.Get(expectedId),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(category.Id, result.Id);
        }

        [Fact]
        public async Task Create_Category()
        {
            var newCategory = new Category
            {
                Description = "newDescription",
            };

            _repository.Setup(_ => _.Create(newCategory));

            ICategoriesService service = new CategoriesService(_repository.Object);

            await service.Create(newCategory);

            _repository.Verify(_ => _.Create(newCategory),
                Times.Once);
        }

        [Fact]
        public async Task Update_Category()
        {
            const int expectedId = 1;

            var category = new Category
            {
                Id = expectedId,
                Description = "First Category"
            };

            var updatedCategory = new Category
            {
                Description = "updatedDescription"
            };

            _repository.Setup(_ => _.Get(expectedId))
                .ReturnsAsync(category);

            _repository.Setup(_ => _.Update(category));

            ICategoriesService service = new CategoriesService(_repository.Object);

            await service.Update(updatedCategory, expectedId);

            _repository.Verify(_ => _.Get(expectedId),
                Times.Once);

            _repository.Verify(_ => _.Update(category),
                Times.Once);
        }

        [Fact]
        public async Task Delete_Category()
        {
            const int expectedId = 1;

            var category = new Category
            {
                Id = expectedId,
                Description = "First Category"
            };

            _repository.Setup(_ => _.Get(expectedId))
                .ReturnsAsync(category);

            _repository.Setup(_ => _.Delete(category));

            ICategoriesService service = new CategoriesService(_repository.Object);

            await service.Delete(expectedId);

            _repository.Verify(_ => _.Get(expectedId),
                Times.Once);

            _repository.Verify(_ => _.Delete(category),
                Times.Once);
        }
    }
}
