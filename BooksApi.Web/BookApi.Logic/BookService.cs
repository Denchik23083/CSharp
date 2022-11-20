using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db;
using BookApi.Db.Entities;
using BookApi.WebDb;

namespace BookApi.Logic
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository, BookContext context)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Book> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task Create(Book book)
        {
            await _repository.Create(book);
        }

        public async Task Update(Book book, int id)
        {
            var bookToUpdate = await _repository.Get(id);

            if (bookToUpdate is null)
            {
                throw new ArgumentNullException();
            }

            await _repository.Update(bookToUpdate, book);
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _repository.Get(id);

            if (bookToDelete is null)
            {
                throw new ArgumentNullException();
            }

            await _repository.Delete(bookToDelete);
        }
    }
}
