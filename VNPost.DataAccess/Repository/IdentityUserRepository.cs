using System;
using Microsoft.AspNetCore.Identity;
using VNPost.DataAccess.Data;

namespace VNPost.DataAccess.Repository.IRepository
{
    public class IdentityUserRepository : Repository<IdentityUser>, IIdentityUserRepository
    {
        public IdentityUserRepository(ApplicationDbContext db) : base(db)
        {
        }

        public IdentityUser Get(string id)
        {
            return dbSet.Find(id);
        }

        public void Remove(string uid)
        {
            IdentityUser entity = dbSet.Find(uid);
            Remove(entity);
        }
    }
}
