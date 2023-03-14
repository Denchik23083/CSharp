using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db.Entities;

namespace BookApi.Logic
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();

        Task<Category> Get(int id);

        Task Create(Category category);

        Task Update(Category category, int id);

        Task Delete(int id);
    }
}