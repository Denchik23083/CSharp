using Identity.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace Identity.WebDb
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateAsync(User user, string? password)
        {
            return await _userManager.CreateAsync(user, password);
        }
    }
}