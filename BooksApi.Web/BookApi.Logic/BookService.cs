using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookApi.Db;
using BookApi.Db.Entities;
using BookApi.WebDb;

namespace BookApi.Logic
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly BookContext _context;

        public BookService(IBookRepository repository, BookContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book Get(int id)
        {
            return _repository.Get(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Update(Book book)
        {
            var bookToUpdate = _context.Books.FirstOrDefault(b => b.Id == book.Id);

            if (bookToUpdate is null)
            {
                throw new ArgumentNullException();
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PagesCount = book.PagesCount;
            bookToUpdate.PublishDate = book.PublishDate;

            _context.SaveChanges();

            _repository.Update(bookToUpdate);
        }

        public void Delete(int id)
        {
            var bookToDelete = _context.Books.FirstOrDefault(b => b.Id == id);

            if (bookToDelete is null)
            {
                throw new ArgumentNullException();
            }

            _repository.Delete(bookToDelete);
        }
    }
}
