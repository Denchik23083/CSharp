using System;
using System.Collections.Generic;
using System.Text;
using Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=RepositoryService;Integrated Security=True;");
        }

        public DbSet<Book> Books { get; set; }
    }
}
