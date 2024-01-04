using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityApp.WebDb.AuthRepository
{
    public interface IAuthRepository
    {
        Task<IdentityResult> CreateAsync(User user, string? password);
    }
}