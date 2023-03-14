using System;
using BookApi.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApi.Db.EntityConfig
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Title);
            builder.Property(_ => _.Author);
            builder.Property(_ => _.PagesCount);
            builder.Property(_ => _.PublishDate);

            builder.HasOne(_ => _.Category)
                .WithMany(_ => _.Books)
                .HasForeignKey(_ => _.CategoryId);

            builder.ToTable("Books").HasData(
                new Book
                {
                    Id = 1,
                    Title = "Гарри Поттер и философский камень",
                    Author = "Джоан Роулинг",
                    PagesCount = 500,
                    PublishDate = new DateTime(1997, 06, 26),
                    CategoryId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Гарри Поттер и Тайная комната",
                    Author = "Джоан Роулинг",
                    PagesCount = 450,
                    PublishDate = new DateTime(1998, 07, 02),
                    CategoryId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Гарри Поттер и узник Азкабана",
                    Author = "Джоан Роулинг",
                    PagesCount = 600,
                    PublishDate = new DateTime(1999, 07, 08),
                    CategoryId = 1
                },
                new Book
                {
                    Id = 4,
                    Title = "Гарри Поттер и Кубок огня",
                    Author = "Джоан Роулинг",
                    PagesCount = 700,
                    PublishDate = new DateTime(2000, 07, 08),
                    CategoryId = 2
                });
        }
    }
}
