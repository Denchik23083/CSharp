using Caching.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Caching.Db
{
    public class CachingContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        
        public CachingContext(DbContextOptions<CachingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}