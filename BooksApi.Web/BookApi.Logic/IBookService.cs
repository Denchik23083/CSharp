using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Db.Entities;

namespace BookApi.Logic
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();

        Task<Book> Get(int id);

        Task Create(Book book);

        Task Update(Book book, int id);

        Task Delete(int id);
    }
}
