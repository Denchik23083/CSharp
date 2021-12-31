﻿using System.Collections.Generic;

namespace AuthSample.WebDb
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();

        Book Get(int id);

        Book Create(Book book);

        void Update(Book book);

        void Delete(Book book);
    }
}