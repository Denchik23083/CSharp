using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.Pages.Books
{
    public partial class AddBookPage
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        public void BackToBooks() => NavigationManager.NavigateTo("/books");
    }
}
