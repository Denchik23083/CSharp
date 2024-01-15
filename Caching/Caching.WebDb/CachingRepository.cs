using Caching.Db;
using Caching.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Caching.WebDb
{
    public class CachingRepository : ICachingRepository
    {
        private readonly CachingContext _context;

        public CachingRepository(CachingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUser(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(_ => _.Id == id);
        }
    }
}