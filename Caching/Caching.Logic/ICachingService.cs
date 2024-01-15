using Caching.Db.Entities;

namespace Caching.Logic
{
    public interface ICachingService
    {
        public Task<IEnumerable<User>> GetUsers();

        public Task<User> GetUser(int id);

        public Task Create(User user);
    }
}