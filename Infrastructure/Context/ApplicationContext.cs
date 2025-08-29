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
            // Static datetime for seed data
            var seedDateTime = new DateTime(2025, 8, 28, 0, 0, 0, DateTimeKind.Utc);
            var systemUserId = new Guid("00000000-0000-0000-0000-000000000001");

            modelBuilder.Entity<Status>().HasData(
                new Status 
                { 
                    Id = new Guid("10000000-0000-0000-0000-000000000001"),
                    Name = "In Progress",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                },
                new Status 
                { 
                    Id = new Guid("10000000-0000-0000-0000-000000000002"),
                    Name = "Submitted",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                },
                new Status 
                { 
                    Id = new Guid("10000000-0000-0000-0000-000000000003"),
                    Name = "Resolved",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category 
                { 
                    Id = new Guid("20000000-0000-0000-0000-000000000001"),
                    Name = "Road",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                },
                new Category 
                { 
                    Id = new Guid("20000000-0000-0000-0000-000000000002"),
                    Name = "Waste",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                },
                new Category 
                { 
                    Id = new Guid("20000000-0000-0000-0000-000000000003"),
                    Name = "Electricity",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User 
                { 
                    Id = new Guid("30000000-0000-0000-0000-000000000001"),
                    Email = "SuperAdmin", 
                    PasswordHash = "$2a$11$.vCYWiCOAuf.t/.fOGHGeeeEcTxmXeeBqGxQRoiMlkyrLmjJz0epu", 
                    Role = UserRole.Admin,
                    FullName = "System Administrator",
                    CreatedBy = systemUserId,
                    Createdon = seedDateTime,
                    IsDeleted = false,
                    IsDeletedBy = Guid.Empty,
                    IsDeletedOn = default,
                    LastModifiedBy = systemUserId,
                    LastModifiedOn = seedDateTime
                }
            );
        }
    }
}