namespace BooksApi.Web.Models.BooksModels
{
    public class BooksReadModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public int PagesCount { get; set; }

        public DateTime PublishDate { get; set; }

        public int CategoryId { get; set; }
    }
}
