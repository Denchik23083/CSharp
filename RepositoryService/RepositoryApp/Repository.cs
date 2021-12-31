using System;
using System.Collections.Generic;
using System.Linq;
using Db;
using Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryApp
{
    public class Repository : IRepository
    {
        private readonly BookContext _context = new BookContext();

        public IEnumerable<Book> GetAll()
        {
            var books = _context.Books;

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}, {book.Title}, {book.Author}, {book.PagesCount}, {book.PublishDate}");
            }

            return books;
        }

        public Book Get(int id)
        {
            var books = _context.Books;
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book is null)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine($"{book.Id}, {book.Title}, {book.Author}, {book.PagesCount}, {book.PublishDate}");

            return book;
        }

        public Book Create(Book book)
        {
            _context.Books.Add(book);

            _context.SaveChanges();

            return book;
        }

        public void Update(Book book)
        {
            
        }

        public void Remove(Book book)
        {
            _context.Books.Remove(book);

            _context.SaveChanges();
        }
    }
}
