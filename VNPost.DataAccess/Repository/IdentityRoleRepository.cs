using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using VNPost.DataAccess.Data;

namespace VNPost.DataAccess.Repository.IRepository
{
    public class IdentityRoleRepository : Repository<IdentityRole>, IIdentityRoleRepository
    {
        public IdentityRoleRepository(ApplicationDbContext db) : base(db)
        {
        }

        public IdentityRole Get(string id)
        {
            return dbSet.Find(id);
        }

        public void Update(IdentityRole role, string name)
        {
            IdentityRole objFromDb = _db.IdentityRoles.FirstOrDefault(s => s.Id == role.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = name;
            }
        }
    }
}
