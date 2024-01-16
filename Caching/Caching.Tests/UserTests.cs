using Caching.Db.Entities;
using Caching.Logic;
using Caching.WebDb;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using Xunit;

namespace Caching.Tests
{
    public class UserTests
    {
        private readonly Mock<ICachingRepository> _repository;
        private readonly Mock<IMemoryCache> _memoryCache;

        public UserTests()
        {
            _repository = new Mock<ICachingRepository>();
            _memoryCache = new Mock<IMemoryCache>();
        }

        [Fact]
        public async void GetUsers()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "Tom", Email = "tom@gmail.com", Age = 35 },
                new User { Id = 2, Name = "Alice", Email = "alice@yahoo.com", Age = 29 },
                new User { Id = 3, Name = "Sam", Email = "sam@online.com", Age = 37 }
            };

            _repository.Setup(_ => _.GetUsersAsync())
                .ReturnsAsync(users);

            ICachingService service = new CachingService(_repository.Object, _memoryCache.Object);

            var result = await service.GetUsersAsync();

            _repository.Verify(_ => _.GetUsersAsync(),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(users.Count(), result.Count());
        }

        [Fact]
        public async void GetUser()
        {
            var expectedId = 1;

            var user = new User
            {
                Id = expectedId, 
                Name = "Tom", 
                Email = "tom@gmail.com", 
                Age = 35
            };

            _repository.Setup(_ => _.GetUserAsync(expectedId))
                .ReturnsAsync(user);

            _memoryCache.Setup(_ => _.CreateEntry(It.IsAny<object>()))
                .Returns(Mock.Of<ICacheEntry>);

            ICachingService service = new CachingService(_repository.Object, _memoryCache.Object);

            var result = await service.GetUserAsync(expectedId);

            _repository.Verify(_ => _.GetUserAsync(expectedId),
                Times.Once);

            _memoryCache.Verify(_ => _.CreateEntry(It.IsAny<object>()),
                Times.Once);

            Assert.NotNull(result);
            Assert.Equal(user, result);
        }

        [Fact]
        public async void CreateUser()
        {
            var expectedId = 5;

            var user = new User
            {
                Id = expectedId,
                Name = "Tom2",
                Email = "tom2@gmail.com",
                Age = 34
            };

            var userModel = new User
            {
                Name = "Tom2",
                Email = "tom2@gmail.com",
                Age = 34
            };

            _repository.Setup(_ => _.CreateUserAsync(userModel))
                .ReturnsAsync(user);

            _memoryCache.Setup(_ => _.CreateEntry(It.IsAny<object>()))
                .Returns(Mock.Of<ICacheEntry>);

            ICachingService service = new CachingService(_repository.Object, _memoryCache.Object);

            await service.CreateUserAsync(userModel);

            _repository.Verify(_ => _.CreateUserAsync(userModel),
                Times.Once);

            _memoryCache.Verify(_ => _.CreateEntry(It.IsAny<object>()),
                Times.Once);

            Assert.Equal(userModel.Name, user.Name);
            Assert.Equal(userModel.Email, user.Email);
            Assert.Equal(userModel.Age, user.Age);
        }

        [Fact]
        public async void UpdateUser()
        {
            var expectedId = 5;

            var user = new User
            {
                Id = expectedId,
                Name = "Tom2",
                Email = "tom2@gmail.com",
                Age = 34
            };

            var userModel = new User
            {
                Id = expectedId,
                Name = "Tom3",
                Email = "tom3@gmail.com",
                Age = 35
            };

            _repository.Setup(_ => _.GetUserAsync(userModel.Id))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.UpdateUserAsync(user));

            _memoryCache.Setup(_ => _.CreateEntry(It.IsAny<object>()))
                .Returns(Mock.Of<ICacheEntry>);

            ICachingService service = new CachingService(_repository.Object, _memoryCache.Object);

            await service.UpdateUserAsync(userModel);

            _repository.Verify(_ => _.GetUserAsync(userModel.Id),
                Times.Once);

            _repository.Verify(_ => _.UpdateUserAsync(user),
                Times.Once);

            _memoryCache.Verify(_ => _.CreateEntry(It.IsAny<object>()),
                Times.Once);

            Assert.Equal(userModel.Name, user.Name);
            Assert.Equal(userModel.Email, user.Email);
            Assert.Equal(userModel.Age, user.Age);
        }

        [Fact]
        public async void DeleteUser()
        {
            var expectedId = 5;

            var user = new User
            {
                Id = expectedId,
                Name = "Tom2",
                Email = "tom2@gmail.com",
                Age = 34
            };

            _repository.Setup(_ => _.GetUserAsync(expectedId))
                .ReturnsAsync(user);

            _repository.Setup(_ => _.DeleteUserAsync(user));

            _memoryCache.Setup(_ => _.Remove(It.IsAny<object>()));

            ICachingService service = new CachingService(_repository.Object, _memoryCache.Object);

            await service.DeleteUserAsync(expectedId);

            _repository.Verify(_ => _.GetUserAsync(expectedId),
                Times.Once);

            _repository.Verify(_ => _.DeleteUserAsync(user),
                Times.Once);

            _memoryCache.Verify(_ => _.Remove(It.IsAny<object>()),
                Times.Once);
        }
    }
}