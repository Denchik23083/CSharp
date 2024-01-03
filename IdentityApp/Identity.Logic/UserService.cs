using Identity.Db.Entities;
using Identity.WebDb;
using Microsoft.AspNetCore.Identity;

namespace Identity.Logic
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IdentityResult> CreateAsync(User user, string? password)
        {
            return await _repository.CreateAsync(user, password);
        }
    }
}