using System.Collections.Generic;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;
using MvcEntity.WebDb;

namespace MvcEntity.Logic
{
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _repository;

        public static List<Phone> _phones = new List<Phone>();

        public PhoneService(IPhoneRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Phone>> GetPhone()
        {
            var phone = await _repository.GetPhone();

            return phone;
        }

        public async Task<Phone> Push(int id)
        {
            var pushPhone = await _repository.Push(id);

            _phones.Add(pushPhone);

            return pushPhone;
        }
    }
}