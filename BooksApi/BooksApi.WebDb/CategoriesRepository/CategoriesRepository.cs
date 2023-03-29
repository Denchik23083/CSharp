using BooksApi.Db;
using BooksApi.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.WebDb.CategoriesRepository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly BooksContext _context;

        public CategoriesRepository(BooksContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories
                .Include(_ => _.Books)
                .ToListAsync();
        }

        public async Task<Category> Get(int id)
        {
            var category = await _context.Categories
                .Include(_ => _.Books)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (category is null)
            {
                throw new ArgumentNullException();
            }

            return category;
        }

        public async Task Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Category categoryToUpdate, Category category)
        {
            categoryToUpdate.Description = category.Description;
            categoryToUpdate.Books = category.Books;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Category categoryToDelete)
        {
            _context.Categories.Remove(categoryToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
