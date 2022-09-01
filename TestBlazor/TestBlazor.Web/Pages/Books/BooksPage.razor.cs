using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Db.Entities.Books;

namespace TestBlazor.Web.Pages.Books
{
    public partial class BooksPage
    {
        [Inject] IBookService BookService { get; set; }

        [Inject] NavigationManager NavigationManager { get; set; }

        public IEnumerable<Book> Books { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Books = await BookService.GetAllBooks();
        }

        protected override async Task OnParametersSetAsync()
        {
            Books = await BookService.GetAllBooks();
        }

        public void Id(int id) => NavigationManager.NavigateTo($"/books/{id}");

        public void Add() => NavigationManager.NavigateTo("/books/addBook");

        public void Edit(int id) => NavigationManager.NavigateTo($"/books/{id}/edit");

        public async Task Remove(int id)
        {
            var result = await BookService.RemoveBook(id);

            if (result)
            {
                NavigationManager.NavigateTo("/books", true);
            }
        }
    }
}
