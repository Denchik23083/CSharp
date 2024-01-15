using Caching.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Caching.Db.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();
            builder.Property(_ => _.Email).IsRequired();
            builder.Property(_ => _.Age).IsRequired();

            builder.HasData(new List<User>
            {
                new User { Id = 1, Name = "Tom", Email = "tom@gmail.com", Age = 35 },
                new User { Id = 2, Name = "Alice", Email = "alice@yahoo.com", Age = 29 },
                new User { Id = 3, Name = "Sam", Email = "sam@online.com", Age = 37 }
            });
        }
    }
}
