using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.Logic.AuthService
{
    public interface IAuthService
    {
        Task<IdentityResult> CreateAsync(User user, string? password);
    }
}