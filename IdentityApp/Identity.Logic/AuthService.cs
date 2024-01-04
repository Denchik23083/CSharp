using Identity.Db.Entities;
using Identity.WebDb;
using Microsoft.AspNetCore.Identity;

namespace Identity.Logic
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public async Task<IdentityResult> CreateAsync(User user, string? password)
        {
            return await _repository.CreateAsync(user, password);
        }
    }
}