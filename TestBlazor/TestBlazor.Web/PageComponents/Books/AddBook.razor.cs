using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.PageComponents.Books
{
    public partial class AddBook
    {
        [Inject] IBookService BookService { get; set; }

        private Book _book = new();

        void AddBooks()
        {
            BookService.Add(_book);
        }
    }
}