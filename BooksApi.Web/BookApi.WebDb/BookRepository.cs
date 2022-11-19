using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db;
using BookApi.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.WebDb
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task Create(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Book bookToUpdate, Book book)
        {
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PagesCount = book.PagesCount;
            bookToUpdate.PublishDate = book.PublishDate;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Book bookToDelete)
        {
            _context.Books.Remove(bookToDelete);

            await _context.SaveChangesAsync();
        }
    }
}
