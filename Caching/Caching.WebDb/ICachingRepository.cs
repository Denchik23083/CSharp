using Caching.Db.Entities;

namespace Caching.WebDb
{
    public interface ICachingRepository
    {        
        public Task<IEnumerable<User>> GetUsersAsync();

        public Task<User?> GetUserAsync(int id);

        public Task<User?> CreateAsync(User user);

        public Task UpdateAsync(User user);

        public Task DeleteAsync(User user);
    }
}