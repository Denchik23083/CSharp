using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db;
using BookApi.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.WebDb
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookContext _context;

        public CategoryRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories
                .Include(_ => _.Books)
                .ToListAsync();
        }

        public async Task<Category> Get(int id)
        {
            return await _context.Categories
                .Include(_ => _.Books)
                .FirstOrDefaultAsync(_ => _.Id == id);
        }

        public async Task Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Category categoryToUpdate, Category category)
        {
            categoryToUpdate.Description = category.Description;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Category categoryToDelete)
        {
            _context.Categories.Remove(categoryToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
