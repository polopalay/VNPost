using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData.AddSeedDataToMenu(builder);
            SeedData.AddSeedDataBanner(builder);
            SeedData.AddSeedToCategory(builder);
            SeedData.AddSeedToPost(builder);
            SeedData.AddSeedToService(builder);
            SeedData.AddSeedToColumnist(builder);
            SeedData.AddSeedToRole(builder);
            SeedData.AddSeedToUser(builder);
            SeedData.AddSeedToRoleUser(builder);
            SeedData.AddSeedToPermission(builder);
            SeedData.AddSeedToStatuses(builder);
            builder.Entity<Parcel>(entity => entity.HasIndex(e => e.Code).IsUnique());
        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Posts { get; set; }
        public DbSet<ServiceDetail> ServiceDetails { get; set; }
        public DbSet<Columnist> Columnists { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<IdentityUser> IdentityUsers { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
