using System.Collections.Generic;
using BookApi.Db.Entities;

namespace BooksApi.Web.Models
{
    public class CategoryWriteModel
    {
        public string Description { get; set; }

        public List<Book> Books { get; set; }
    }
}
