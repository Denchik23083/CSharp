using System;
using System.Linq;
using BookApi.Db;
using BookApi.Db.Entities;
using Xunit;

namespace BookApi.Tests
{
    public class BookApiTest
    {
        [Fact]
        public void Get_All_Books()
        {
            var context = new TestsBookContext();
            var expectedBooks = 4;

            var books = context.Books;
            Assert.NotNull(books);

            Assert.Equal(expectedBooks, books.Count());
        }

        [Fact]
        public void Get_Book()
        {
            var context = new TestsBookContext();
            var expectedId = 2;

            var book = context.Books.FirstOrDefault(b => b.Id == expectedId);

            Assert.NotNull(book);
            Assert.Equal(expectedId, book.Id);
        }

        [Fact]
        public void Create()
        {
            var context = new TestsBookContext();

            var book = new Book
            {
                Title = "Гарри Поттер и печера страха",
                Author = "Дж. Роуль",
                PagesCount = 600,
                PublishDate = new DateTime(1979, 01, 11)
            };

            context.Books.Add(book);
            context.SaveChanges();

            var created = context.Books.FirstOrDefault(
                b => b.Title.Equals(book.Title) &&
                     b.Author.Equals(book.Author) &&
                     b.PagesCount == book.PagesCount &&
                     b.PublishDate == book.PublishDate);

            Assert.NotNull(created);

            context.Books.Remove(created);
            context.SaveChanges();

            var removed = context.Books.FirstOrDefault(
                b => b.Title.Equals(created.Title) &&
                     b.Author.Equals(created.Author) &&
                     b.PagesCount == created.PagesCount &&
                     b.PublishDate == created.PublishDate);

            Assert.Null(removed);
        }

        [Fact]
        public void Update()
        {
            var context = new TestsBookContext();

            var book = new Book
            {
                Title = "Гарри Поттер и пытка",
                Author = "Дж. Роуль",
                PagesCount = 1000,
                PublishDate = new DateTime(1979, 01, 11)
            };

            var expectedId = 2;
            var bookToUpdate = context.Books.FirstOrDefault(b => b.Id == expectedId);

            Assert.NotNull(bookToUpdate);
            Assert.Equal(expectedId, bookToUpdate.Id);

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.PagesCount = book.PagesCount;
            bookToUpdate.PublishDate = book.PublishDate;
            
            context.SaveChanges();

            var updated = context.Books.FirstOrDefault(
                b => b.Title.Equals(book.Title) &&
                     b.Author.Equals(book.Author) &&
                     b.PagesCount == book.PagesCount &&
                     b.PublishDate == book.PublishDate);

            Assert.NotNull(updated);
        }

        [Fact]
        public void Remove()
        {
            var context = new TestsBookContext();

            var book = new Book
            {
                Title = "Гарри Поттер и печера страха",
                Author = "Дж. Роуль",
                PagesCount = 600,
                PublishDate = new DateTime(1979, 01, 11)
            };

            context.Books.Add(book);
            context.SaveChanges();

            var created = context.Books.FirstOrDefault(
                b => b.Title.Equals(book.Title) &&
                     b.Author.Equals(book.Author) &&
                     b.PagesCount == book.PagesCount &&
                     b.PublishDate == book.PublishDate);

            Assert.NotNull(created);

            context.Books.Remove(created);
            context.SaveChanges();

            var removed = context.Books.FirstOrDefault(
                b => b.Title.Equals(created.Title) &&
                     b.Author.Equals(created.Author) &&
                     b.PagesCount == created.PagesCount &&
                     b.PublishDate == created.PublishDate);

            Assert.Null(removed);
        }
    }
}