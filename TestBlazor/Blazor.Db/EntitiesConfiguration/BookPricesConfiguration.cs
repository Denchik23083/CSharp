using Blazor.Db.Entities.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blazor.Db.EntitiesConfiguration
{
    public class BookPricesConfiguration : IEntityTypeConfiguration<BookPrices>
    {
        public void Configure(EntityTypeBuilder<BookPrices> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder
                .HasOne(_ => _.Book)
                .WithOne(_ => _.BookPrices)
                .HasForeignKey<BookPrices>(_ => _.BookId);
        }
    }
}
