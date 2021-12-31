using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcEntity.Db;
using MvcEntity.Db.Entities;
using MvcEntity.WebDb;

namespace MvcEntity.Logic
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        private readonly MvcContext _context;
        private static User _user;

        private static List<Phone> _phones = new List<Phone>();

        public Service(IRepository repository, MvcContext context)
        {
            _repository = repository;
            _context = context;
        }

        public async Task<User> Login(User model)
        {
            var user = await _repository.Login(model);

            _user = user;

            return user;
        }

        public async Task Register(User model)
        {
            await _repository.Register(model);
        }

        public async Task<List<Phone>> GetPhone()
        {
            var phone = await _repository.GetPhone();

            return phone;
        }

        public async Task AddPhone(Phone model)
        {
            await _repository.AddPhone(model);
        }

        public async Task<Phone> GetToEditPhone(int id)
        {
            var getToEditPhone = await _repository.GetToEditPhone(id);

            return getToEditPhone;
        }

        public async Task EditPhone(Phone model)
        {
            var editPhone = _repository.EditPhone(model);

            _context.Phones.Update(editPhone);

            await _context.SaveChangesAsync();
        }

        public async Task DeletePhone(int id)
        {
            await _repository.DeletePhone(id);
        }

        public User GetUser()
        {
            var user = _user;

            _repository.GetUser(user);

            return user;
        }

        public async Task EditUser(User user)
        {
            var userToUpdate = await _repository.EditUser(_user);

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser()
        {
            await _repository.DeleteUser(_user.Id);
        }

        public async Task<Phone> Push(int id)
        {
            var pushPhone = await _repository.Push(id);

            _phones.Add(pushPhone);

            return pushPhone;
        }

        public List<Phone> List()
        {
            return _phones;
        }

        public void RemovePhoneFromOrder(int id)
        {
            var phoneToRemove = _phones.FirstOrDefault(p => p.Id == id);

            _phones.Remove(phoneToRemove);
        }

        public async Task<bool> Payment()
        {
            var totalPrice = 0;
            var isPayment = false;

            foreach (var price in _phones)
            {
                totalPrice += price.Price;
            }

            if (_user.Balance >= totalPrice)
            {
                isPayment = true;

                await _repository.Payment(totalPrice);

                _phones.Clear();
            }

            return isPayment;
        }

        public void Replenish(Replenish replenish)
        {
            _repository.Replenish(replenish);
        }
    }
}
