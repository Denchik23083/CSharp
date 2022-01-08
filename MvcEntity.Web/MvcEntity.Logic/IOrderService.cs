using System.Collections.Generic;
using MvcEntity.Db.Entities;

namespace MvcEntity.Logic
{
    public interface IOrderService
    {
        List<Phone> List();

        void RemovePhoneFromOrder(int id);
    }
}