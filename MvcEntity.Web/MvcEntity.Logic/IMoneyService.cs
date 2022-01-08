using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.Logic
{
    public interface IMoneyService
    {
        Task<bool> Payment();

        void Replenish(Replenish replenish);
    }
}