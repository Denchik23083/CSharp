using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.WebDb.AuthRepository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<User> _userManager;

        public AuthRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateAsync(User user, string? password)
        {
            return await _userManager.CreateAsync(user, password);
        }
    }
}