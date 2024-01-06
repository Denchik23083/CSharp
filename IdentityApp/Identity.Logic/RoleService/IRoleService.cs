using IdentityApp.Core.Utilities;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic.RoleService
{
    public interface IRoleService
    {
        Task<IEnumerable<IdentityRole>> GetRolesAsync();

        Task<Role> GetRoleAsync(string userId);

        Task<IdentityResult> CreateRoleAsync(IdentityRole role);

        Task UpdateRoleAsync(string userId, List<string> roles);

        Task<IdentityResult> DeleteRoleAsync(string id);
    }
}