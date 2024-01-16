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

        public async Task<IEnumerable<User>?> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(_ => _.Id == id);
        }

        public async Task<User?> CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();

            return user;
        }

        public async Task UpdateAsync(User user)
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
        }
    }
}