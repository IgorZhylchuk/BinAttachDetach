using BinAttachmentApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinAttachment.Models
{
    public class ApplicationDBContext : IdentityDbContext<UsersIdentity, IdentityRole, string>
    {

        public DbSet<BinAttachmentModel> Bins { get; set; }
        public DbSet<ProcessModel> Processes { get; set; }
        public DbSet<MachineModel> Machines { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContext) : base(dbContext)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            DefaultUsers.SeedData(builder);
        }
    }
}
