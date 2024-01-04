using IdentityApp.Db.Entities;
using IdentityApp.WebDb.AuthRepository;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic.AuthService
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