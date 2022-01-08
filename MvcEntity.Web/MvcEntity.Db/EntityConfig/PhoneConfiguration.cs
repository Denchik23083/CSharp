using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcEntity.Db.Entities;

namespace MvcEntity.Db.EntityConfig
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Name).HasMaxLength(255).IsRequired();
            builder.Property(_ => _.Company).HasMaxLength(255).IsRequired();
            builder.Property(_ => _.Price).HasMaxLength(255).IsRequired();
        }
    }
}