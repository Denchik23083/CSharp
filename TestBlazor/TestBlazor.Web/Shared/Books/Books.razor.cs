using System.Collections.Generic;
using Blazor.Db.Entities.Books;
using Blazor.Logic.BooksService;
using Microsoft.AspNetCore.Components;

namespace TestBlazor.Web.Shared.Books
{
    public partial class Books
    {
        [Inject] IBookService BookService { get; set; }

        [Inject] NavigationManager Manager { get; set; }

        private IEnumerable<Book> _books;
        public bool IsEdit = false;
        private Book _book = new();
        private Book _bookById;
        public int BookId;
        public int EditId;
        public bool IsId = false;

        protected override void OnInitialized()
        {
            _books = BookService.GetAll();
        }

        private void Add()
        {
            Manager.NavigateTo("/books/addBook");
        }

        void Edit(int id)
        {
            EditId = id;
            IsEdit = true;
        }

        private void Remove(int id)
        {
            BookService.Delete(id);
        }
    }
}