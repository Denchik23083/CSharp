using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db.Entities;

namespace BookApi.WebDb
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();

        Task<Book> Get(int id);

        Task Create(Book book);

        Task Update(Book bookToUpdate, Book book);

        Task Delete(Book bookToDelete);
    }
}
