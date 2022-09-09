using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Db.Entities.Books;
using Blazor.WebDb.BooksRepository;

namespace Blazor.Logic.BooksService
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _repository.GetAllBooks();
        }

        public async Task<Book> GetBook(int id)
        {
            return await _repository.GetBook(id);
        }

        public async Task<BookPrices> GetBookPrices(int bookId)
        {
            return await _repository.GetBookPrices(bookId);
        }

        public async Task<bool> AddBook(Book book)
        {
            return await _repository.AddBook(book);
        }

        public async Task<bool> UpdateBook(Book book, int id)
        {
            return await _repository.UpdateBook(book, id);
        }

        public async Task<bool> RemoveBook(int id)
        {
            return await _repository.RemoveBook(id);
        }
    }
}
