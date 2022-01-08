using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.Logic
{
    public interface IUserService
    {
        User GetUser();

        Task EditUser(User user);

        Task DeleteUser();
    }
}