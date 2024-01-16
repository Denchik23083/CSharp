using Caching.Db.Entities;

namespace Caching.WebDb
{
    public interface ICachingRepository
    {        
        public Task<IEnumerable<User>?> GetUsersAsync();

        public Task<User?> GetUserAsync(int id);

        public Task<User?> CreateUserAsync(User user);

        public Task UpdateUserAsync(User user);

        public Task DeleteUserAsync(User user);
    }
}