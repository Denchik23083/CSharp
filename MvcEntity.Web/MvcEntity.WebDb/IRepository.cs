using System.Collections.Generic;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public interface IRepository
    {
        Task<User> Login(User model);

        Task Register(User model);

        Task<List<Phone>> GetPhone();

        Task AddPhone(Phone model);

        Task<Phone> GetToEditPhone(int id);

        Phone EditPhone(Phone model);

        Task DeletePhone(int id);

        User GetUser(User user);

        Task<User> EditUser(User user);

        Task DeleteUser(int id);

        Task<Phone> Push(int id);

        Task Replenish(Replenish replenish);

        Task Payment(int totalPrice);
    }
}
