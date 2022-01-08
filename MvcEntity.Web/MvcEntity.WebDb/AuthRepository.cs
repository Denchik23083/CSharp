using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEntity.Db;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public class AuthRepository : IAuthRepository
    {
        private readonly MvcContext _context;
        public static User _user;

        public AuthRepository(MvcContext context)
        {
            _context = context;
        }

        public async Task<User> Login(User model)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);

            _user = user;

            return user;
        }

        public async Task Register(User user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }
    }
}