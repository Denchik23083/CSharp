using AuthSample.AuthDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthSample.AuthDb.EntityConfig
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.HasOne(_ => _.Role)
                .WithMany(_ => _.RolePermissions)
                .HasForeignKey(_ => _.RoleId);

            builder.Property(_ => _.PermissionType).HasConversion<int>();
        }
    }
}
