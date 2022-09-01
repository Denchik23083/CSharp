using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Db.Entities.Books;

namespace Blazor.Logic.BooksService
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBook(int id);

        Task<bool> AddBook(Book book);

        Task<bool> UpdateBook(Book book, int id);

        Task<bool> RemoveBook(int id);
    }
}
