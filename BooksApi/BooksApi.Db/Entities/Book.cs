﻿using System.Text.Json.Serialization;

namespace BooksApi.Db.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public int PagesCount { get; set; }

        public DateTime PublishDate { get; set; }

        public int? CategoryId { get; set; }

        [JsonIgnore] 
        public Category? Category { get; set; }
    }
}
