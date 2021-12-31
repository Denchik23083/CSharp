using System.Collections.Generic;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.Logic
{
    public interface IService
    {
        Task<User> Login(User model);

        Task Register(User model);

        Task<List<Phone>> GetPhone();

        Task AddPhone(Phone model);

        Task<Phone> GetToEditPhone(int id);

        Task EditPhone(Phone model);

        Task DeletePhone(int id);

        User GetUser();

        Task EditUser(User user);

        Task DeleteUser();

        Task<Phone> Push(int id);

        List<Phone> List();

        void RemovePhoneFromOrder(int id);

        Task<bool> Payment();

        void Replenish(Replenish replenish);
    }
}
