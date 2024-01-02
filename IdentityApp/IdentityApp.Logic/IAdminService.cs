using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic
{
    public interface IAdminService
    {
        Task<IEnumerable<IdentityUser>> GetUsersAsync();
    }
}