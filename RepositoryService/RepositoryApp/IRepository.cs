using System;
using System.Collections.Generic;
using System.Text;
using Db;
using Db.Entities;

namespace RepositoryApp
{
    public interface IRepository
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);

        Book Create(Book book);

        void Update(Book book);

        void Remove(Book book);
    }
}
