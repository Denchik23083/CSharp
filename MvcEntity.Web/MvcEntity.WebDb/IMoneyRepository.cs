using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public interface IMoneyRepository
    {
        Task Replenish(Replenish replenish);

        Task Payment(int totalPrice);
    }
}