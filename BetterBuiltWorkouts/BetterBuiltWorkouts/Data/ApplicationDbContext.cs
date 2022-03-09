using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BetterBuiltWorkouts.Models;
using Microsoft.AspNetCore.Identity;

namespace BetterBuiltWorkouts.Data
{
    // IdentityDbContext inherits from the normal DbContext class but add additional items needed for AA 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string adminRoleId = Guid.NewGuid().ToString("D");
            string suspendedRoleId = Guid.NewGuid().ToString("D");
            string user1Id = Guid.NewGuid().ToString("D");
            string user2Id = Guid.NewGuid().ToString("D");
            string user3Id = Guid.NewGuid().ToString("D");

            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name = "Suspended",
                    NormalizedName = "SUSPENDED",
                    Id = suspendedRoleId,
                    ConcurrencyStamp = suspendedRoleId
                });

            ApplicationUser user1 = new ApplicationUser
            {
                Id = user1Id,
                Email = "drewxcom@gmail.com",
                NormalizedEmail = "DREWXCOM@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Drew",
                LastName = "Crawford",
                UserName = "drewxcom",
                NormalizedUserName = "DREWXCOM"
            };

            ApplicationUser user2 = new ApplicationUser
            {
                Id = user2Id,
                Email = "hale.l.c91@gmail.com",
                NormalizedEmail = "HALE.L.C91@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Cody",
                LastName = "Hale",
                UserName = "chale",
                NormalizedUserName = "CHALE"
            };

            ApplicationUser user3 = new ApplicationUser
            {
                Id = user3Id,
                Email = "Karamuja.sabina@gmail.com",
                NormalizedEmail = "KARAMUJA.SABINA@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Sabina",
                LastName = "Karamuja",
                UserName = "skaramuja",
                NormalizedUserName = "SKARAMUJA"
            };

            PasswordHasher<ApplicationUser> u1 = new PasswordHasher<ApplicationUser>();
            user1.PasswordHash = u1.HashPassword(user1, "crawford1!Drew");

            PasswordHasher<ApplicationUser> u2 = new PasswordHasher<ApplicationUser>();
            user2.PasswordHash = u2.HashPassword(user2, "hale1!Cody");

            PasswordHasher<ApplicationUser> u3 = new PasswordHasher<ApplicationUser>();
            user3.PasswordHash = u1.HashPassword(user3, "karamuja1!Sabina");

            builder.Entity<ApplicationUser>().HasData(user1);
            builder.Entity<ApplicationUser>().HasData(user2);
            builder.Entity<ApplicationUser>().HasData(user3);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = user1Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = user2Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = user3Id
                }
                );



        }
    }
}
