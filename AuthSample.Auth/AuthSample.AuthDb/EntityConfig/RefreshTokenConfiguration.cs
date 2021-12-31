using System;
using System.Collections.Generic;
using System.Text;
using AuthSample.AuthDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthSample.AuthDb.EntityConfig
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.HasOne(_ => _.User)
                .WithOne(_ => _.RefreshToken)
                .HasForeignKey<RefreshToken>(_ => _.UserId);
        }
    }
}
