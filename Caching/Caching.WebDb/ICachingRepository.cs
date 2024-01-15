using Caching.Db.Entities;

namespace Caching.WebDb
{
    public interface ICachingRepository
    {        
        public Task<IEnumerable<User>> GetUsers();

        public Task<User?> GetUser(int id);
    }
}