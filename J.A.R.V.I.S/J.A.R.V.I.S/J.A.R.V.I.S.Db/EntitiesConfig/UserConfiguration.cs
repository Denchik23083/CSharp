using System;
using J.A.R.V.I.S.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace J.A.R.V.I.S.Db.EntitiesConfig
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();

            builder.ToTable("User").HasData(
                new User
                {
                    Id = 1,
                    Name = "Denis"
                });
        }
    }
}
