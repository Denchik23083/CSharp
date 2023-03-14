using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db.Entities;

namespace BookApi.WebDb
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();

        Task<Category> Get(int id);

        Task Create(Category category);

        Task Update(Category categoryToUpdate, Category category);

        Task Delete(Category categoryToDelete);
    }
}