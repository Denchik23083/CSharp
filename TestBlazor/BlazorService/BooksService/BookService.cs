using System.Collections.Generic;
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
        
        public IEnumerable<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book Get(int id)
        {
            return _repository.Get(id);
        }

        public Book Add(Book book)
        {
            return _repository.Add(book);
        }

        public void Update(Book book, int id)
        {
            _repository.Update(book, id);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
