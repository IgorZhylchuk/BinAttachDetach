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

        public static BinAttachmentModel Detach(ApplicationDBContext dBContext, string binNumber)
        {
            var bin = dBContext.Bins.Where(n => n.BinNumber == binNumber).Select(b => b).FirstOrDefault();
            bin.BinNumber = bin.BinNumber;
            bin.BinStatus = "Free to use";

            bin.Machine = null;
            bin.MachineName = null;
            bin.ProcessId = 0;
            bin.ProcessName = null;

            return bin;
           // dBContext.Bins.Update(bin);
            //await dBContext.SaveChangesAsync();
        }
        public static BinAttachmentModel Attach(ApplicationDBContext dBContext, AttachedStringNamesModel model)
        {
            BinAttachmentModel bin = new BinAttachmentModel();
            bin.Id = dBContext.Bins.Where(n => n.BinNumber == model.BinNumber).Select(i => i.Id).Single();
            bin.MachineName = dBContext.Machines.Where(i => i.Id == Int32.Parse(model.MachineName)).Select(n => n.Name).Single();
            bin.Machine = dBContext.Machines.Where(m => m.ProcessModelId == Int32.Parse(model.ProcessName)).Where(m => m.Id == Int32.Parse(model.MachineName)).Select(m => m).Single();
            bin.ProcessId = Int32.Parse(model.ProcessName);
            bin.ProcessName = dBContext.Processes.Where(i => i.Id == Int32.Parse(model.ProcessName)).Select(n => n.Name).Single();
            bin.BinNumber = model.BinNumber;
            bin.BinStatus = "Filling";
            return bin;
        }
    }
}
