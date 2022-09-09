using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Db.Entities.Books;

namespace Blazor.WebDb.BooksRepository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBook(int id);

        Task<BookPrices> GetBookPrices(int bookId);

        Task<bool> AddBook(Book book);

        Task<bool> UpdateBook(Book book, int id);

        Task<bool> RemoveBook(int id);
    }
}
