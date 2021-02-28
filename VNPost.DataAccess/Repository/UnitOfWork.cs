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
        public IBannerRepository Banner { get; }
        public IMenuRepository Menu { get; }
        public IArticleRepository Article { get; }
        public ICategoryRepository Category { get; }
        public IServiceRepository Service { get; }
        public IServiceDetailRepository ServiceDetail { get; }
        public IColumnistRepository Columnist { get; }
        public IRolePermissionRepository RolePermission { get; }
        public IPermissionRepository Permissions { get; }
        public IIdentityUserRepository IdentityUser { get; }
        public IIdentityRoleRepository IdentityRole { get; }
        public IIdentityUserRoleRepository IdentityUserRole { get; }
        public IDistrictRepository District { get; }
        public ILocationRepository Location { get; }
        public IParcelRepository Parcel { get; }
        public IProvinceRepository Province { get; }
        public IStatusRepository Status { get; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Banner = new BannerRepository(_db);
            Menu = new MenuRepository(_db);
            Article = new ArticleRepository(_db);
            Category = new CategoryRepository(_db);
            Service = new ServiceRepository(_db);
            ServiceDetail = new ServiceDetailRepository(_db);
            Columnist = new ColumnistRepository(_db);
            RolePermission = new RolePermissionRepository(_db);
            Permissions = new PermissionRepository(_db);
            IdentityUser = new IdentityUserRepository(_db);
            IdentityRole = new IdentityRoleRepository(_db);
            IdentityUserRole = new IdentityUserRoleRepository(_db);
            District = new DistrictRepository(_db);
            Location = new LocationRepository(_db);
            Parcel = new ParcelRepository(_db);
            Province = new ProvinceRepository(_db);
            Status = new StatusRepository(_db);
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
