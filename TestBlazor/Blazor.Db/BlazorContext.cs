using Blazor.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Db
{
    public class BlazorContext : DbContext
    {
        public BlazorContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
    }
}
