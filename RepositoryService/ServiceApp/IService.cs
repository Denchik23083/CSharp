using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Db.Entities;

namespace ServiceApp
{
    public interface IService
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);

        Book Create(Book book);

        void Update(Book book);

        void Remove(int id);
    }
}
