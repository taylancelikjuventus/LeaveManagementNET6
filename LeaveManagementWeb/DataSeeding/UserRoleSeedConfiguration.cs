using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementWeb.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
       

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                
                new IdentityUserRole<string>() { 
                    UserId = "cba45d42-5bea-4bb1-a6f7-f367e9055223",
                    RoleId = "cba45d42-5bea-4bb1-a6f7-f367e9095223"
                }  ,
               
                 new IdentityUserRole<string>()
                 {
                     UserId = "cfa45d42-3bea-4bb1-a6f7-f367e9055223",
                     RoleId = "cba45d42-5bda-4bb1-a6f7-f667e9095227"
                 }


           );
        }
    }
}