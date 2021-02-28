using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBannerRepository Banner { get; }
        IMenuRepository Menu { get; }
        IGalleryRepository Gallery { get; }
        IArticleRepository Article { get; }
        ICategoryRepository Category { get; }
        IPostRepository Post { get; }
        IServiceRepository Service { get; }
        IColumnistRepository Columnist { get; }
        IColumnistItemRepository ColumnistItem { get; }
        IRolePermissionRepository RolePermission { get; }
        IPermissionRepository Permissions { get; }
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
