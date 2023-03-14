using BookApi.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Db.EntityConfig
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Description).IsRequired();

            builder.ToTable("Categories").HasData(
                new Category
                {
                    Id = 1,
                    Description = "First Category"
                },
                new Category
                {
                    Id = 2,
                    Description = "Second Category"
                });
        }
    }
}
