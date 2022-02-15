using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.PageComponents.Books
{
    public partial class EditBook
    {
        [Inject] private IBookService BookService { get; set; }

        [Inject] NavigationManager Manager { get; set; }

        [Parameter] public Book Book { get; set; }

        [Parameter] public int EditId { get; set; }

        [Parameter] public bool IsEdit { get; set; }

        void EditBooks()
        {
            BookService.Update(Book, EditId);
            IsEdit = false;
            Manager.NavigateTo("/books", true);
        }
    }
}