using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.Pages.Books
{
    public partial class BooksDetailsPage
    {
        [Parameter] public int BookId { get; set; }
    }
}
