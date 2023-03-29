using BooksApi.Db.Entities;
using BooksApi.WebDb.CategoriesRepository;

namespace BooksApi.Logic.CategoriesService
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _repository;

        public CategoriesService(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Category> Get(int id)
        {
            var category = await _repository.Get(id);

            if (category is null)
            {
                throw new ArgumentNullException();
            }

            return category;
        }

        public async Task Create(Category category)
        {
            await _repository.Create(category);
        }

        public async Task Update(Category category, int id)
        {
            var categoryToUpdate = await _repository.Get(id);

            if (categoryToUpdate is null)
            {
                throw new ArgumentNullException();
            }

            await _repository.Update(categoryToUpdate, category);
        }

        public async Task Delete(int id)
        {
            var categoryToDelete = await _repository.Get(id);

            if (categoryToDelete is null)
            {
                throw new ArgumentNullException();
            }

            await _repository.Delete(categoryToDelete);
        }
    }
}
