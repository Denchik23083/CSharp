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

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _repository.GetUsers();
        }

        public async Task<User> GetUser(int id)
        {
            if (_memoryCache.TryGetValue(id, out User cacheUser))
            {
                return cacheUser;
            }

            var user = await _repository.GetUser(id);

            if (user is null)
            {
                throw new ArgumentNullException("User not found");
            }

            _memoryCache.Set(user.Id, user,
                new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(10)));

            return user;
        }
    }
}