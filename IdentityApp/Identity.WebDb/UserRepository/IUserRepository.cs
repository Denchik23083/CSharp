using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.WebDb.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserAsync(string id);

        Task<IdentityResult> CreateUserAsync(User user, string? password);
        
        Task<IdentityResult> UpdateUserAsync(User userToUpdate);

        Task<IdentityResult> DeleteUserAsync(User userToDelete);
    }
}