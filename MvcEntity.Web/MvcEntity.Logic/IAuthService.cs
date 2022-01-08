using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.Logic
{
    public interface IAuthService
    {
        Task<User> Login(User model);

        Task Register(User model);
    }
}