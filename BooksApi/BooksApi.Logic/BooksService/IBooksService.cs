using BooksApi.Db.Entities;

namespace BooksApi.Logic.BooksService
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAll();

        Task<IEnumerable<Book>> GetAllBooksCategories();

        Task<Book> Get(int id);

        Task Create(Book book);

        Task Update(Book book, int id);

        Task Delete(int id);
    }
}
