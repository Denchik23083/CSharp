using AuthSample.WebDb;
using System.Collections.Generic;

namespace AuthSample.Web.Logic
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);

        Book Create(Book book);

        void Update(Book book);

        void Delete(int id);
    }
}
