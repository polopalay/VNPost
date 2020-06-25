using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;

namespace VNPost.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IMenuItemRepository MenuItem { get; }
        public IMenuLocationRepository MenuLocation { get; }
        public IMenuLinkRepository MenuLink { get; }
        public IGalleryRepository Gallery { get; }
        public IArticleRepository Article { get; }
        public ICategoryRepository Category { get; }
        public IPostRepository Post { get; }
        public IServiceRepository Service { get; }
        public IColumnistRepository Columnist { get; }
        public IColumnistItemRepository ColumnistItem { get; }
        public IRolePermissionRepository RolePermission { get; }
        public ICURDRepository CURD { get; }
        public IIdentityUserRepository IdentityUser { get; }
        public IIdentityRoleRepository IdentityRole { get; }
        public IIdentityUserRoleRepository IdentityUserRole { get; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            MenuItem = new MenuItemRepository(_db);
            MenuLocation = new MenuLocationRepository(_db);
            MenuLink = new MenuLinkRepository(_db);
            Gallery = new GalleryRepository(_db);
            Article = new ArticleRepository(_db);
            Category = new CategoryRepository(_db);
            Post = new PostRepository(_db);
            Service = new ServiceRepository(_db);
            Columnist = new ColumnistRepository(_db);
            ColumnistItem = new ColumnistItemRepository(_db);
            RolePermission = new RolePermissionRepository(_db);
            CURD = new CURDRepository(_db);
            IdentityUser = new IdentityUserRepository(_db);
            IdentityRole = new IdentityRoleRepository(_db);
            IdentityUserRole = new IdentityUserRoleRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
