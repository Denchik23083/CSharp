using BooksApi.Db.Entities;

namespace BooksApi.Logic.CategoriesService
{
    public interface ICategoriesService
    {
        Task<IEnumerable<Category>> GetAll();

        Task<Category> Get(int id);

        Task Create(Category category);

        Task Update(Category category, int id);

        Task Delete(int id);
    }
}
