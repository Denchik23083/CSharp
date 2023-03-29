using BooksApi.Db.Entities;

namespace BooksApi.Web.Models.CategoriesModels
{
    public class CategoriesWriteModel
    {
        public string? Description { get; set; }

        public List<Book> Books { get; set; } = new();
    }
}
