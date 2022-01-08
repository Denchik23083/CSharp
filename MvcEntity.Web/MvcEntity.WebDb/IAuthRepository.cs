using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public interface IAuthRepository
    {
        Task<User> Login(User model);

        Task Register(User model);
    }
}