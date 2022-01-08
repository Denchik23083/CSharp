using System.Collections.Generic;
using System.Threading.Tasks;
using MvcEntity.Db;
using MvcEntity.Db.Entities;
using MvcEntity.WebDb;

namespace MvcEntity.Logic
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly MvcContext _context;

        private static List<Phone> _phones = new List<Phone>();

        public UserService(IUserRepository repository, MvcContext context)
        {
            _repository = repository;
            _context = context;
        }

        public User GetUser()
        {
            var user = AuthService._user;

            _repository.GetUser(user);

            return user;
        }

        public async Task EditUser(User user)
        {
            var userToUpdate = await _repository.EditUser(AuthService._user);

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;

            _context.Users.Update(userToUpdate);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser()
        {
            await _repository.DeleteUser(AuthService._user.Id);
        }
    }
}