using System.Collections.Generic;
using Blazor.Db.Entities;
using Blazor.WebDb;

namespace Blazor.Logic
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
