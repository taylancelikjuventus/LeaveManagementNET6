﻿using LeaveManagementWeb.DataSeeding;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<LeaveRequest> LeaveRequests { get; set; }  

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /*
            builder.Entity<IdentityRole>().HasData(
                
                new IdentityRole() { Id = new Guid().ToString() , Name ="Admin"  , NormalizedName="ADMIN" } ,

                new IdentityRole() { Id = new Guid().ToString(), Name = "User", NormalizedName = "USER" }

           );
            */

            //Yada Configuration class ı kullanılır
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());


        }


       


    }
}