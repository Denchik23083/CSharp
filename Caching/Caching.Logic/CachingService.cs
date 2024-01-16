using Caching.Db.Entities;
using Caching.WebDb;
using Microsoft.Extensions.Caching.Memory;

namespace Caching.Logic
{
    public class CachingService : ICachingService
    {
        private readonly ICachingRepository _repository;
        private readonly IMemoryCache _memoryCache;

        public CachingService(ICachingRepository repository, IMemoryCache memoryCache)
        {
            _repository = repository;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var users = await _repository.GetUsersAsync();

            if (users is null)
            {
                throw new ArgumentNullException("Users not found");
            }

            return users;
        }

        public async Task<User> GetUserAsync(int id)
        {
            if (_memoryCache.TryGetValue(id, out User cacheUser))
            {
                return cacheUser;
            }

            var user = await _repository.GetUserAsync(id);

            if (user is null)
            {
                throw new ArgumentNullException("User not found");
            }

            _memoryCache.Set(user.Id, user, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));

            return user;
        }

        public async Task CreateUserAsync(User user)
        {
            var userToCreate = await _repository.CreateUserAsync(user);

            if (userToCreate is null)
            {
                throw new ArgumentNullException("User not found");
            }

            _memoryCache.Set(userToCreate.Id, userToCreate, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));
        }

        public async Task UpdateUserAsync(User user)
        {
            var userToUpdate = await _repository.GetUserAsync(user.Id);

            if (userToUpdate is null)
            {
                throw new ArgumentNullException("User not found");
            }

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Age = user.Age;

            await _repository.UpdateUserAsync(userToUpdate);

            _memoryCache.Set(userToUpdate.Id, userToUpdate, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));
        }

        public async Task DeleteUserAsync(int id)
        {
            var userToDelete = await _repository.GetUserAsync(id);

            if (userToDelete is null)
            {
                throw new ArgumentNullException("User not found");
            }

            await _repository.DeleteUserAsync(userToDelete);

            _memoryCache.Remove(userToDelete.Id);
        }
    }
}