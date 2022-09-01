﻿using System.Reflection.Metadata;
using System.Threading.Tasks;
using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.PageComponents.Books
{
    public partial class AddEditBookComponent
    {
        [Parameter] public bool Add { get; set; }

        [Parameter] public bool Edit { get; set; }

        [Parameter] public int EditId { get; set; }

        [Inject] public IBookService BookService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public Book FormBook = new();

        public async Task Submit()
        {
            if (Add)
            {
                var result = await BookService.AddBook(FormBook);

                if (result)
                {
                    NavigationManager.NavigateTo("/books");
                }
            }
            if (Edit)
            {
                var result = await BookService.UpdateBook(FormBook, EditId);

                if (result)
                {
                    NavigationManager.NavigateTo("/books");
                }
            }
        }
    }
}