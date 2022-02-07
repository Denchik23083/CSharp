using Blazor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blazor.Db.EntitiesConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Title).IsRequired();
            builder.Property(_ => _.Author).IsRequired();
            builder.Property(_ => _.PagesCount).IsRequired();
            builder.Property(_ => _.PublishDate).IsRequired();
        }
    }
}
