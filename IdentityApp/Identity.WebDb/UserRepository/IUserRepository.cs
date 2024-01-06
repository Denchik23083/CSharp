using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;
using IdentityApp.Core.Utilities;

namespace IdentityApp.WebDb.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<IEnumerable<string>> GetUserRolesAsync(User user);

        Task<User> GetUserAsync(string id);

        Task<IdentityResult> CreateUserAsync(User user, string? password);
        
        Task<IdentityResult> UpdateUserAsync(User userToUpdate);

        Task<IdentityResult> DeleteUserAsync(User userToDelete);
        
        Task<IdentityResult> ChangePasswordAsync(User userToUpdate, Password password);
        
        Task AddToRolesAsync(User user, IEnumerable<string> addedRoles);
        
        Task RemoveFromRolesAsync(User user, IEnumerable<string> removedRoles);
    }
}