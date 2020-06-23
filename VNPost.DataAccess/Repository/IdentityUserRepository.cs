using System;
using Microsoft.AspNetCore.Identity;
using VNPost.DataAccess.Data;

namespace VNPost.DataAccess.Repository.IRepository
{
    public class IdentityUserRepository : Repository<IdentityUser>, IIdentityUserRepository
    {
        private readonly ApplicationDbContext _db;

        public IdentityUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
