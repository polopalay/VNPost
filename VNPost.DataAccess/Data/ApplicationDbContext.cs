using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VNPost.Models.Entity;
using VNPost.Utility;

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
            SeedData.AddSeedDataToMenuItem(builder);
            SeedData.AddSeedDataToMenuLocation(builder);
            SeedData.AddSeedDataToMenuLink(builder);
            SeedData.AddSeedToGallery(builder);
            SeedData.AddSeedToArticle(builder);
            SeedData.AddSeedToCategory(builder);
            SeedData.AddSeedToPost(builder);
            SeedData.AddSeedToService(builder);
            SeedData.AddSeedToColumnist(builder);
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuLink> MenuLinks { get; set; }
        public DbSet<MenuLocation> MenuLocations { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Columnist> Columnists { get; set; }
    }
}
