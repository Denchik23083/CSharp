using IdentityApp.Db.Entities;

namespace IdentityApp.Logic.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
    }
}