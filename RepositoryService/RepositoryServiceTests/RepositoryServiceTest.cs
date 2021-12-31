using System;
using System.Linq;
using Db;
using Db.Entities;
using Microsoft.Data.SqlClient;
using RepositoryApp;
using Xunit;
using Xunit.Abstractions;

namespace RepositoryServiceTests
{
    public class RepositoryServiceTest
    {
        private readonly BookContext _context = new BookContext();

        [Fact]
        public void GetAll()
        {
            var books = _context.Books;

            //Work
            Assert.Equal(2, books.Count());
        }

        [Fact]
        public void GetId()
        {
            var expectedId = 2;

            var books = _context.Books;
            var book = books.FirstOrDefault(b => b.Id == expectedId);

            if (book is null)
            {
                throw new ArgumentNullException();
            }

            //Work
            Assert.NotNull(book);
            Assert.Equal(expectedId, book.Id);
        }

        [Fact]
        public void Create()
        {
            var book = new Book
            {
                Title = "Гарри Поттер и печера страха",
                Author = "Дж. Роуль",
                PagesCount = 600,
                PublishDate = new DateTime(1979, 01, 11)
            };

            _context.Books.Add(book);

            //Work
            /*_context.SaveChanges();*/

            var create = _context.Books.Count();

            Assert.Equal(2, create);
        }

        [Fact]
        public void Update()
        {
            var bookToUpdate = new Book
            {
                Title = "Гарри Поттер и пытка",
                Author = "Дж. Роуль",
                PagesCount = 1000,
                PublishDate = new DateTime(1979, 01, 11)
            };

            var expectedId = 2;

            var books = _context.Books;
            var book = books.FirstOrDefault(b => b.Id == expectedId);

            if (book is null)
            {
                throw new ArgumentNullException();
            }

            book.Title = bookToUpdate.Title;
            book.Author = bookToUpdate.Author;
            book.PagesCount = bookToUpdate.PagesCount;
            book.PublishDate = bookToUpdate.PublishDate;

            //Work
            /*_context.SaveChanges();*/

            Assert.NotNull(book);
            Assert.Equal(expectedId, book.Id);
        }

        [Fact]
        public void Remove()
        {
            var expectedId = 7;

            var books = _context.Books;
            var book = books.FirstOrDefault(b => b.Id == expectedId);

            if (book is null)
            {
                throw new ArgumentNullException();
            }

            books.Remove(book);

            //Work
            /*_context.SaveChanges();*/

            var deleted = _context.Books.Count();

            Assert.Equal(1, deleted);
        }
    }
}