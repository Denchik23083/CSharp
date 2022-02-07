using System.Collections.Generic;
using Blazor.Db.Entities;

namespace Blazor.Logic
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);

        Book Add(Book book);

        void Update(Book book, int id);

        void Delete(int id);
    }
}
