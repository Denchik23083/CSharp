using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcEntity.Db.Entities;

namespace MvcEntity.Db.EntityConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).HasMaxLength(255).IsRequired();
            builder.Property(_ => _.Balance).IsRequired();
            builder.Property(_ => _.Email).HasMaxLength(255).IsRequired();
            builder.Property(_ => _.Password).HasMaxLength(255).IsRequired();
        }
    }
}
