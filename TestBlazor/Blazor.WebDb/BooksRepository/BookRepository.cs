using System;
using System.Collections.Generic;
using System.Linq;
using Blazor.Db;
using Blazor.Db.Entities.Books;

namespace Blazor.WebDb.BooksRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly BlazorContext _context;

        public BookRepository(BlazorContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }

        public Book Get(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);

            return book;
        }

        public Book Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return book;
        }

        public void Update(Book book, int id)
        {
            var bookToUpdate = _context.Books.FirstOrDefault(b => b.Id == id);

            if (bookToUpdate is null)
            {
                throw new ArgumentNullException();
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PagesCount = book.PagesCount;
            bookToUpdate.PublishDate = book.PublishDate;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var bookToDelete = _context.Books.FirstOrDefault(b => b.Id == id);

            if (bookToDelete is null)
            {
                throw new ArgumentNullException();
            }

            _context.Books.Remove(bookToDelete);
            _context.SaveChanges();
        }
    }
}
