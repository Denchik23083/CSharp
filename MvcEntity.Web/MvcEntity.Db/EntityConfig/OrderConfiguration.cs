using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MvcEntity.Db.Entities;

namespace MvcEntity.Db.EntityConfig
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Address).HasMaxLength(255).IsRequired();
            builder.Property(_ => _.ContactPhone).HasMaxLength(255).IsRequired();
        }
    }
}
