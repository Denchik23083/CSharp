using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.Pages.Books
{
    public partial class EditBookPage
    {
        [Parameter] public int EditId { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public void BackToBooks() => NavigationManager.NavigateTo("/books");
    }
}
