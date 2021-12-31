using System;
using System.Collections.Generic;
using System.Text;
using Db;
using Db.Entities;
using ServiceApp;

namespace ControllerApp
{
    public class Controller
    {
        private readonly IService _service;

        public Controller(IService service)
        {
            _service = service;
        }

        public IEnumerable<Book> GetAll()
        {
            return _service.GetAll();
        }

        public Book Get(int id)
        {
            return _service.Get(id);
        }

        public Book Create(Book book)
        {
            return _service.Create(book);
        }

        public void Update(Book book, int id)
        {
            book.Id = id;
            _service.Update(book);
        }

        public void Remove(int id)
        {
            _service.Remove(id);
        }
    }
}
