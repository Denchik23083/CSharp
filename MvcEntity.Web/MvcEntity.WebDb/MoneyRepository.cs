using System.Threading.Tasks;
using MvcEntity.Db;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public class MoneyRepository : IMoneyRepository
    {
        private readonly MvcContext _context;

        public MoneyRepository(MvcContext context)
        {
            _context = context;
        }

        public async Task Payment(int totalPrice)
        {
            AuthRepository._user.Balance -= totalPrice;

            _context.Users.Update(AuthRepository._user);

            await _context.SaveChangesAsync();
        }

        public async Task Replenish(Replenish replenish)
        {
            AuthRepository._user.Balance += replenish.Money;

            _context.Users.Update(AuthRepository._user);

            await _context.SaveChangesAsync();
        }
    }
}