using IdentityApp.Web.Utilities.WebDb;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Web.Utilities.Logic
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repository;

        public AdminService(IAdminRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<IdentityUser>> GetUsersAsync()
        {
            return await _repository.GetUsersAsync();
        }
    }
}