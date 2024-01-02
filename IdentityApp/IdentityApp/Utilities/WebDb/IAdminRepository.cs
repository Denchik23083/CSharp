using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Web.Utilities.WebDb
{
    public interface IAdminRepository
    {
        Task<IEnumerable<IdentityUser>> GetUsersAsync();
    }
}