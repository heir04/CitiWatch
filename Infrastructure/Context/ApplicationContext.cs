using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitiWatch.Domain.Entities;
using CitiWatch.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CitiWatch.Infrastructure.Context
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
            new Status { Name = "In Progress" },
                new Status { Name = "Submitted" },
                new Status { Name = "Resolved" }
            );

            modelBuilder.Entity<Category>().HasData(
            new Category { Name = "Road" },
                new Category { Name = "Waste" },
                new Category { Name = "Electricity" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Email = "SuperAdmin", PasswordHash = "$2a$11$.vCYWiCOAuf.t/.fOGHGeeeEcTxmXeeBqGxQRoiMlkyrLmjJz0epu", Role = UserRole.Admin}
            );
        }
    }
}