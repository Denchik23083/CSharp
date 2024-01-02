using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic
{
    public class AdminService : IAdminService
    {
        public Task<IEnumerable<IdentityUser>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }
    }
}