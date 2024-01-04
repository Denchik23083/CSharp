using IdentityApp.Db.Entities;

namespace IdentityApp.WebDb.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}