using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Db;
using Blazor.Db.Entities.Books;
using Microsoft.EntityFrameworkCore;

namespace Blazor.WebDb.BooksRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly BlazorContext _context;

        public BookRepository(BlazorContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<BookPrices> GetBookPrices(int bookId)
        {
            return await _context.BookPrices.FirstOrDefaultAsync(b => b.BookId == bookId);
        }

        public async Task<bool> AddBook(Book book, BookPrices bookPrices)
        {
            await _context.Books.AddAsync(book);
            await _context.BookPrices.AddAsync(bookPrices);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateBook(Book book, BookPrices bookPrices, int id)
        {
            var bookToUpdate = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

            if (bookToUpdate is null)
            {
                return false;
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PagesCount = book.PagesCount;
            bookToUpdate.PublishDate = book.PublishDate;

            var priceToUpdate = _context.BookPrices.FirstOrDefault(b => b.BookId == bookToUpdate.Id);

            if (priceToUpdate is null)
            {
                return false;
            }

            priceToUpdate.Price = bookPrices.Price;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> RemoveBook(int id)
        {
            var bookToDelete = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

            if (bookToDelete is null)
            {
                return false;
            }

            var priceToDelete = await _context.BookPrices.FirstOrDefaultAsync(b => b.BookId == id);

            if (priceToDelete is null)
            {
                return false;
            }

            _context.Books.Remove(bookToDelete);
            _context.BookPrices.Remove(priceToDelete);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
