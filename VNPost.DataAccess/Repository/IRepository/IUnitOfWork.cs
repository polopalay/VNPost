using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IMenuItemRepository MenuItem { get; }
        IMenuLocationRepository MenuLocation { get; }
        IMenuLinkRepository MenuLink { get; }
        IGalleryRepository Gallery { get; }
        IArticleRepository Article { get; }
        ICategoryRepository Category { get; }
        IPostRepository Post { get; }
        IServiceRepository Service { get; }
        IColumnistRepository Columnist { get; }
        IColumnistItemRepository ColumnistItem { get; }
        IRolePermissionRepository RolePermission { get; }
        ICURDRepository CURD { get; }
        IIdentityUserRepository IdentityUser { get; }
        IIdentityRoleRepository IdentityRole { get; }
        IIdentityUserRoleRepository IdentityUserRole { get; }
        IDistrictRepository District { get; }
        ILocationRepository Location { get; }
        IParcelRepository Parcel { get; }
        IProvinceRepository Province { get; }
        IStatusRepository Status { get; }
        void Save();
    }
}
