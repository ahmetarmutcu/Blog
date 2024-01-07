using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserRoleMap:IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId=Guid.Parse("B18C6BA1-CF72-4A18-8ABD-A74FA9D13E7E"),
                RoleId=Guid.Parse("B3450D43-1EFB-4588-9440-AF054CA0865A")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("9DC26124-EB8C-458B-B5B9-5D5253B1678D"),
                RoleId = Guid.Parse("A2DD20D7-0402-42DB-B720-5277D8100A7A")
            }
            );
        }
    }
}
