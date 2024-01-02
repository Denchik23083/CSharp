using Microsoft.AspNetCore.Identity;

namespace IdentityApp.WebDb
{
    public interface IAdminRepository
    {
        Task<IEnumerable<IdentityUser>> GetUsersAsync();
    }
}