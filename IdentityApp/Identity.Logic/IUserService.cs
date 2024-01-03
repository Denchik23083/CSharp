using Identity.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace Identity.Logic
{
    public interface IUserService
    {
        Task<IdentityResult> CreateAsync(User user, string? password);
    }
}