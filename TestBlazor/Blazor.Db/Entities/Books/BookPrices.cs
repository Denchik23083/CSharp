namespace Blazor.Db.Entities.Books
{
    public class BookPrices
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public Book Book { get; set; }

        public int BookId { get; set; }
    }
}
