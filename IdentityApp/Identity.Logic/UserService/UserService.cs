using IdentityApp.Db.Entities;
using IdentityApp.WebDb.UserRepository;

namespace IdentityApp.Logic.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _repository.GetUsersAsync();
        }
    }
}
