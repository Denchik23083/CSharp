using System.Collections.Generic;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.Logic
{
    public interface IPhoneService
    {
        Task<List<Phone>> GetPhone();

        Task<Phone> Push(int id);
    }
}