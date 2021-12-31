using System;
using System.Collections.Generic;
using BookApi.Db.Entities;
using BookApi.WebDb;

namespace BookApi.Logic
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
