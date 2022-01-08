using System.Threading.Tasks;
using MvcEntity.Db.Entities;
using MvcEntity.WebDb;

namespace MvcEntity.Logic
{
    public class MoneyService : IMoneyService
    {
        private readonly IMoneyRepository _repository;

        public MoneyService(IMoneyRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Payment()
        {
            var totalPrice = 0;
            var isPayment = false;

            foreach (var price in PhoneService._phones)
            {
                totalPrice += price.Price;
            }

            if (AuthService._user.Balance >= totalPrice)
            {
                isPayment = true;

                await _repository.Payment(totalPrice);

                PhoneService._phones.Clear();
            }

            return isPayment;
        }

        public void Replenish(Replenish replenish)
        {
            _repository.Replenish(replenish);
        }
    }
}