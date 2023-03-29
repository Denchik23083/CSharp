using BooksApi.Db.Entities;

namespace BooksApi.Web.Models.BooksModels
{
    public class BooksWriteModel
    {
        public string? Title { get; set; }

        public string? Author { get; set; }

        public int PagesCount { get; set; }

        public DateTime PublishDate { get; set; }

        public int CategoryId { get; set; }
    }
}
