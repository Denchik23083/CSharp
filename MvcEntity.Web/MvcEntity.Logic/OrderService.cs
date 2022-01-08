using System.Collections.Generic;
using MvcEntity.Db.Entities;
using MvcEntity.WebDb;

namespace MvcEntity.Logic
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public List<Phone> List()
        {
            var list = _repository.List(PhoneService._phones);

            return list;
        }

        public void RemovePhoneFromOrder(int id)
        {
            _repository.RemovePhoneFromOrder(PhoneService._phones, id);
        }
    }
}