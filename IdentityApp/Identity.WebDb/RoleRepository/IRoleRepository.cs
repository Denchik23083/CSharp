using Microsoft.AspNetCore.Identity;

namespace IdentityApp.WebDb.RoleRepository
{
    public interface IRoleRepository
    {
        Task<IEnumerable<IdentityRole>> GetRolesAsync();

        Task<IdentityRole> GetRoleAsync(string id);

        Task<IdentityResult> CreateRoleAsync(IdentityRole role);
        
        Task<IdentityResult> DeleteRoleAsync(IdentityRole roleToDelete);    
    }
}