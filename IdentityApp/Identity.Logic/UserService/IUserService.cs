using IdentityApp.Core.Utilities;
using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserAsync(string id);

        Task<IdentityResult> CreateUserAsync(User user, string? password);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> DeleteUserAsync(string id);

        Task<IdentityResult> ChangePasswordAsync(Password password);
    }
}