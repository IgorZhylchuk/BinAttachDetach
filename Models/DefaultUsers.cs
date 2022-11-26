using BinAttachmentApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinAttachment.Models
{
    public static class DefaultUsers
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ADM_ID = ADMIN_ID;

            const string NUsers_ID = "a12be9c5-aa65-4af6-bd97-00bd9344e575";
            const string ROLE_NUser_ID = NUsers_ID;


            MainBinAttachment binAttachment = new MainBinAttachment();
            modelBuilder.Entity<ProcessModel>().HasData(binAttachment.Processes);
            modelBuilder.Entity<MachineModel>().HasData(binAttachment.Machines);


            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ADM_ID,
                Name = "Admin"
            },
            new IdentityRole
            {
                Id = ROLE_NUser_ID,
                Name = "NormalUser"
            });

            var hasher = new PasswordHasher<UsersIdentity>();

            List<UsersIdentity> users = new List<UsersIdentity>() { 
                new UsersIdentity
                {
                Id = ADMIN_ID,
                NormalizedUserName = "Sara",
                UserName = "Sara",
                EmailConfirmed = true,
                Email = "sara@gmail.com",
                NormalizedEmail = "sara@gmail.com",
                PasswordHash = hasher.HashPassword(null, "demo"),
                SecurityStamp = string.Empty
                },
                new UsersIdentity
                {
                Id = NUsers_ID,
                NormalizedUserName = "Petro",
                UserName = "Petro",
                EmailConfirmed = true,
                Email = "petro@gmail.com",
                NormalizedEmail = "petro@gmail.com",
                PasswordHash = hasher.HashPassword(null, "demo"),
                SecurityStamp = string.Empty
                }
            };
            BinAttachmentModel bin = new BinAttachmentModel
            {
                Id = 1,
                BinNumber = "00-20-10-135",
                BinStatus = "Free to use"

            };
            modelBuilder.Entity<BinAttachmentModel>().HasData(bin);
            modelBuilder.Entity<UsersIdentity>().HasData(users);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ADM_ID,
                UserId = ADMIN_ID
            }
            ,
            new IdentityUserRole<string>
            {
                RoleId = ROLE_NUser_ID,
                UserId = NUsers_ID
            }
            );
        }
    }
}
