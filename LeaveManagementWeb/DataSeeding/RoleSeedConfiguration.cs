using LeaveManagementWeb.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.DataSeeding
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() { Id = "cba45d42-5bea-4bb1-a6f7-f367e9095223",
                    Name = DefinedRoles.Admin,
                    NormalizedName = DefinedRoles.Admin.ToUpper()
                },

                new IdentityRole() { Id = "cba45d42-5bda-4bb1-a6f7-f667e9095227".ToString(),
                    Name = DefinedRoles.User,
                    NormalizedName = DefinedRoles.User.ToUpper() }
                );
               
        }
    }
}