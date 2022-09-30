﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Db.Entities.Books;

namespace Blazor.Logic.BooksService
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBook(int id);

        Task<BookPrices> GetBookPrices(int bookId);

        Task<bool> AddBook(Book book, BookPrices bookPrices);

        Task<bool> UpdateBook(Book book, BookPrices bookPrices, int id);

        Task<bool> RemoveBook(int id);
    }
}
