using System;
using Microsoft.EntityFrameworkCore;

namespace NewsDb
{
    public class NewsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=News;Integrated Security=True;");
        }

        public DbSet<News.News> News { get; set; }
    }
}
