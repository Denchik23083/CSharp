using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace TestBlazor.Web.PageComponents.Books
{
    public partial class BookDetailsComponent
    {
        [Parameter] public int BookId { get; set; }

        [Inject] public IBookService BookService { get; set; }

        public Book Book { get; set; }

        public BookPrices BookPrices { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Book = await BookService.GetBook(BookId);
            BookPrices = await BookService.GetBookPrices(BookId);
        }
    }
}
