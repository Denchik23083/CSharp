using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Web.Utilities.Logic
{
    public interface IAdminService
    {
        Task<IEnumerable<IdentityUser>> GetUsersAsync();
    }
}