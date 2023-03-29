using BooksApi.Db.Entities;

namespace BooksApi.Web.Models.CategoriesModels
{
    public class CategoriesReadModel
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public List<Book> Books { get; set; } = new();
    }
}
