using Caching.Db.Entities;

namespace Caching.Logic
{
    public interface ICachingService
    {
        public Task<IEnumerable<User>> GetUsersAsync();

        public Task<User> GetUserAsync(int id);

        public Task CreateAsync(User user);

        public Task UpdateAsync(User user, int id);

        public Task DeleteAsync(int id);
    }
}