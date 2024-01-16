using Caching.Db.Entities;

namespace Caching.Logic
{
    public interface ICachingService
    {
        public Task<IEnumerable<User>> GetUsersAsync();

        public Task<User> GetUserAsync(int id);

        public Task CreateUserAsync(User user);

        public Task UpdateUserAsync(User user);

        public Task DeleteUserAsync(int id);
    }
}