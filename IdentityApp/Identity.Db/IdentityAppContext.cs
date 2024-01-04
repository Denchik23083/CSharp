using IdentityApp.Db.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Db
{
    public class IdentityAppContext : IdentityDbContext<User>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}