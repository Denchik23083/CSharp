using Identity.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace Identity.Logic
{
    public interface IAuthService
    {
        Task<IdentityResult> CreateAsync(User user, string? password);
    }
}