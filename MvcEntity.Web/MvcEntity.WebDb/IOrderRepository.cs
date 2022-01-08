using System.Collections.Generic;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public interface IOrderRepository
    {
        List<Phone> List(List<Phone> phones);

        void RemovePhoneFromOrder(List<Phone> phones, int id);
    }
}