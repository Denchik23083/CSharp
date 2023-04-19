using BooksApi.Db.Entities;

namespace BooksApi.WebDb.BooksRepository
{
    public interface IBooksRepository
    {
        Task<IEnumerable<Book>> GetAll();

        Task<Book> Get(int id);

        Task Create(Book book);

        Task Update(Book bookToUpdate, Book book);

        Task Delete(Book bookToDelete);
    }
}
