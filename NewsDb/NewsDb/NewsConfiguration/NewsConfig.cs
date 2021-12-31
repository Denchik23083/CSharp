using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NewsDb.NewsConfiguration
{
    public class NewsConfig : IEntityTypeConfiguration<News.News>
    {
        public void Configure(EntityTypeBuilder<News.News> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Seo).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.Title).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.ReadMore).IsRequired().HasMaxLength(255);
            builder.Property(_ => _.NewsCount).IsRequired();
        }
    }
}
