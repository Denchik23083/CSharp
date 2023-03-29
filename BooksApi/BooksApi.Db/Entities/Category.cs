﻿namespace BooksApi.Db.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public List<Book> Books { get; set; } = new();
    }
}
