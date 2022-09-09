using System;
using Blazor.Db.Entities.Books;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Db
{
    public class BlazorContext : DbContext
    {
        public BlazorContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book").HasData(
                new Book
                {
                    Id = 1,
                    Title = "Гарри Поттер и Орден Феникса",
                    Author = "Джоан Роулинг",
                    PagesCount = 500,
                    PublishDate = new DateTime(1988, 06, 14)
                },
                new Book
                {
                    Id = 2,
                    Title = "Гарри Поттер и Кубок Огня",
                    Author = "Джоан Роулинг",
                    PagesCount = 600,
                    PublishDate = new DateTime(1990, 09, 25)
                });

            modelBuilder.Entity<BookPrices>().ToTable("BookPrices").HasData(
                new BookPrices
                {
                    Id = 1,
                    Price = 300,
                    BookId = 1
                },
                new BookPrices
                {
                    Id = 2,
                    Price = 350,
                    BookId = 2
                });

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookPrices> BookPrices { get; set; }
    }
}
