using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class RolePermissionRepository : Repository<RolePermission>, IRolePermissionRepository
    {
        private readonly ApplicationDbContext _db;

        public RolePermissionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
