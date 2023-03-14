﻿using System;
using BookApi.Db.Entities;

namespace BooksApi.Web.Models
{
    public class BookWriteModel
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int PagesCount { get; set; }

        public DateTime PublishDate { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
