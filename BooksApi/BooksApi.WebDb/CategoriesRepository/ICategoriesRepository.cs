using BooksApi.Db.Entities;

namespace BooksApi.WebDb.CategoriesRepository
{
    public interface ICategoriesRepository
    {
        Task<IEnumerable<Category>> GetAll();

        Task<Category> Get(int id);

        Task Create(Category category);

        Task Update(Category categoryToUpdate);

        Task Delete(Category categoryToDelete);
    }
}
