using System;
using BookApi.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Db
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
    }
}
