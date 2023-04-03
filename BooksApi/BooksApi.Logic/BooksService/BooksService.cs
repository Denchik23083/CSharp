using BooksApi.Db.Entities;
using BooksApi.WebDb.BooksRepository;

namespace BooksApi.Logic.BooksService
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _repository;

        public BooksService(IBooksRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<Book>> GetAllBooksCategories()
        {
            return await _repository.GetAllBooksCategories();
        }

        public async Task<Book> Get(int id)
        {
            var book = await _repository.Get(id);

            if (book is null)
            {
                throw new ArgumentNullException();
            }

            return book;
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
