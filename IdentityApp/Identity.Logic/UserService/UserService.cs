using IdentityApp.Core.Exceptions;
using IdentityApp.Core.Utilities;
using IdentityApp.Db.Entities;
using IdentityApp.WebDb.UserRepository;
using Microsoft.AspNetCore.Identity;

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

        public async Task<User> GetUserAsync(string id)
        {
            var user = await _repository.GetUserAsync(id);

            if (user is null)
            {
                throw new UserNotFoundException("User not found");
            }

            return user;
        }

        public async Task<IdentityResult> CreateUserAsync(User user, string? password)
        {
            return await _repository.CreateUserAsync(user, password);
        }

        public async Task<IdentityResult> UpdateUserAsync(User user)
        {
            var userToUpdate = await _repository.GetUserAsync(user.Id);

            if (userToUpdate is null) 
            {
                throw new UserNotFoundException("User not found");
            }

            userToUpdate.UserName = user.UserName;
            userToUpdate.Email = user.Email;
            userToUpdate.Year = user.Year;

            return await _repository.UpdateUserAsync(userToUpdate);
        }

        public async Task<IdentityResult> DeleteUserAsync(string id)
        {
            var userToDelete = await _repository.GetUserAsync(id);

            if (userToDelete is null)
            {
                throw new UserNotFoundException("User not found");
            }

            return await _repository.DeleteUserAsync(userToDelete);
        }

        public async Task<IdentityResult> ChangePasswordAsync(Password password)
        {
            var userToUpdate = await _repository.GetUserAsync(password.Id!);

            if (userToUpdate is null)
            {
                throw new UserNotFoundException("User not found");
            }

            return await _repository.ChangePasswordAsync(userToUpdate, password);
        }
    }
}
