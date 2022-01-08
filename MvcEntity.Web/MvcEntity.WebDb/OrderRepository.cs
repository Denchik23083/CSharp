using System.Collections.Generic;
using System.Linq;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public class OrderRepository : IOrderRepository
    {
        public List<Phone> List(List<Phone> phones)
        {
            return phones;
        }

        public void RemovePhoneFromOrder(List<Phone> phones, int id)
        {
            var phoneToRemove = phones.FirstOrDefault(p => p.Id == id);

            phones.Remove(phoneToRemove);
        }
    }
}