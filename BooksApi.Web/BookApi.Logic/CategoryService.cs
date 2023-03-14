using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db.Entities;
using BookApi.WebDb;

namespace BookApi.Logic
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Category> Get(int id)
        {
            return await _repository.Get(id);
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
