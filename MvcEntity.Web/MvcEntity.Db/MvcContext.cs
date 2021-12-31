using Microsoft.EntityFrameworkCore;
using MvcEntity.Db.Entities;

namespace MvcEntity.Db
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options) { Database.EnsureCreated(); }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
