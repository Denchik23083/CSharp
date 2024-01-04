using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.WebDb.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<User> GetUserAsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<IdentityResult> CreateUserAsync(User user, string? password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> UpdateUserAsync(User userToUpdate)
        {
            return await _userManager.UpdateAsync(userToUpdate);
        }

        public async Task<IdentityResult> DeleteUserAsync(User userToDelete)
        {
            return await _userManager.DeleteAsync(userToDelete);
        }
    }
}
