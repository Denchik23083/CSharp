using System;
using System.Collections.Generic;
using BookApi.Db.Entities;

namespace BookApi.WebDb
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);

        Book Create(Book book);

        void Update(Book book);

        void Delete(Book book);
    }
}
