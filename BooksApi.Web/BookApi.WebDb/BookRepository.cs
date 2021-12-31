using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }

        public Book Get(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
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

        public void Delete(Book book)
        {
            _context.Books.Remove(book);

            _context.SaveChanges();
        }
    }
}
