using System;
using Microsoft.AspNetCore.Identity;
using VNPost.DataAccess.Data;

namespace VNPost.DataAccess.Repository.IRepository
{
    public class IdentityRoleRepository : Repository<IdentityRole>, IIdentityRoleRepository
    {
        private readonly ApplicationDbContext _db;

        public IdentityRoleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
