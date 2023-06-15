using BooksApi.Db;
using BooksApi.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.WebDb.BooksRepository
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return (await _context.Books.FirstOrDefaultAsync(b => b.Id == id))!;
        }

        public async Task Create(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Book bookToUpdate)
        {
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Book bookToDelete)
        {
            _context.Books.Remove(bookToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
