using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public interface IUserRepository
    {
        User GetUser(User user);

        Task<User> EditUser(User user);

        Task DeleteUser(int id);
    }
}