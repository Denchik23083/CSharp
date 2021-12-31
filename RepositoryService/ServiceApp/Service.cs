using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Db;
using Db.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryApp;

namespace ServiceApp
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        private readonly BookContext _context = new BookContext();

        public Service(IRepository repository)
        {
            _repository = repository;
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
            var bookUpdate = _context.Books.FirstOrDefault(b => b.Id == book.Id);

            if (bookUpdate is null) throw new ArgumentException();

            bookUpdate.Title = book.Title;
            bookUpdate.Author = book.Author;
            bookUpdate.PagesCount = book.PagesCount;
            bookUpdate.PublishDate = book.PublishDate;

            _context.SaveChanges();

            _repository.Update(bookUpdate);

        }

        public void Remove(int id)
        {
            var bookDelete = _context.Books.FirstOrDefault(b => b.Id == id);

            if (bookDelete is null) throw new ArgumentException();

            _repository.Remove(bookDelete);
        }
    }
}