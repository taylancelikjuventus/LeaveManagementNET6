using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementData.DataSeeding

{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            PasswordHasher<Employee> hasher = new PasswordHasher<Employee>() ;

            builder.HasData(
               new Employee() { Id = "cba45d42-5bea-4bb1-a6f7-f367e9055223", Firstname="Admin",Lastname="Adminson",UserName= "admin@localhost.com", NormalizedUserName= "admin@localhost.com".ToUpper(), Email="admin@localhost.com",NormalizedEmail= "admin@localhost.com".ToUpper() ,PasswordHash = hasher.HashPassword(null,"Abc123**"),EmailConfirmed=true}
              ,
               new Employee() {Id = "cfa45d42-3bea-4bb1-a6f7-f367e9055223", Firstname = "User", Lastname = "Userson",UserName= "user@localhost.com",NormalizedUserName= "user@localhost.com".ToUpper(), Email = "user@localhost.com", NormalizedEmail = "user@localhost.com".ToUpper(), PasswordHash = hasher.HashPassword(null, "Abc123**"),EmailConfirmed=true }

               );
        }
    }
}