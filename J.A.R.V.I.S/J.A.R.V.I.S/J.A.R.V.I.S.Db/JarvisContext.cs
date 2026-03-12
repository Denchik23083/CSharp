using J.A.R.V.I.S.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace J.A.R.V.I.S.Db
{
    public class JarvisContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Commands> Commands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Jarvis;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
