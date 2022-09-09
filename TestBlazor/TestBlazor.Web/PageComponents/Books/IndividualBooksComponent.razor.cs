using System.Threading.Tasks;
using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.PageComponents.Books
{
    public partial class IndividualBooksComponent
    {
        [Parameter] public Book Book { get; set; }

        [Inject] public IBookService BookService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public BookPrices BookPrices { get; set; }

        protected override async Task OnInitializedAsync()
        {
            BookPrices = await BookService.GetBookPrices(Book.Id);
        }

        public void Id(int id) => NavigationManager.NavigateTo($"/books/{id}");

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
