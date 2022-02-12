using System.Reflection.Metadata;
using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.Shared.Books
{
    public partial class BookById
    {
        [Inject] private IBookService BookService { get; set; }

        [Parameter] public Book ModelBook { get; set; }

        [Parameter] public Book Book { get; set; }

        [Parameter] public int BookId { get; set; }

        [Parameter] public RenderFragment Render { get; set; }

        private void GetBookById()
        {
            Book = BookService.Get(BookId);
        }
    }
}