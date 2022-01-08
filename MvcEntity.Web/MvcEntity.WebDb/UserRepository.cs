using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEntity.Db;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public class UserRepository : IUserRepository
    {
        private readonly MvcContext _context;
        private static User _user;

        public UserRepository(MvcContext context)
        {
            _context = context;
        }

        public User GetUser(User user)
        {
            _user = user;

            return user;
        }

        public async Task<User> EditUser(User user)
        {
            var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);

            return userToUpdate;
        }

        public async Task DeleteUser(int id)
        {
            var userToDelete = await _context.Users.FirstOrDefaultAsync(b => b.Id == id);

            if (userToDelete is null)
            {
                throw new ArgumentNullException();
            }

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }
    }
}