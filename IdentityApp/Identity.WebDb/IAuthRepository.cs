using Identity.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace Identity.WebDb
{
    public interface IAuthRepository
    {
        Task<IdentityResult> CreateAsync(User user, string? password);
    }
}