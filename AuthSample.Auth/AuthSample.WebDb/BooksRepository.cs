using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthSample.WebDb
{
    public class BooksRepository : IBooksRepository
    {
        public static List<Book> Books = new List<Book>
        {
            new Book()
            {
                Id = 1,
                Title = "Капитан",
                Author = "Дж. Роуль",
                PagesCount = 500,
                PublishDate = new DateTime(2002, 05, 06)
            }
        };

        private static int currentId = 2;

        public IEnumerable<Book> GetAll()
        {
            return Books;
        }
        public Book Get(int id)
        {
            return Books.FirstOrDefault(b => b.Id == id);
        }

        public Book Create(Book book)
        {
            book.Id = currentId++;
            Books.Add(book);
            return book;
        }

        public void Update(Book book)
        {
            
        }

        public void Delete(Book toDelete)
        {
            Books.Remove(toDelete);
        }
    }
}
