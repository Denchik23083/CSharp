using System.Collections.Generic;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public interface IPhoneRepository
    {
        Task<List<Phone>> GetPhone();

        Task<Phone> Push(int id);
    }
}