using System.Threading.Tasks;
using MvcEntity.Db.Entities;
using MvcEntity.WebDb;

namespace MvcEntity.Logic
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        public static User _user;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> Login(User model)
        {
            var user = await _repository.Login(model);

            _user = user;

            return user;
        }

        public async Task Register(User model)
        {
            await _repository.Register(model);
        }
    }
}