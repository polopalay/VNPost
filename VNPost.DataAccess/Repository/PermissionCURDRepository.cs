using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class PermissionCURDRepository : Repository<PermissionCURD>, IPermissionCURDRepository
    {
        private readonly ApplicationDbContext _db;

        public PermissionCURDRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
