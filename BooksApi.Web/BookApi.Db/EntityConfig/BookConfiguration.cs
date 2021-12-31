using System;
using System.Collections.Generic;
using System.Text;
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
        }
    }
}
