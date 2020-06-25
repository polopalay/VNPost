using System;
using System.Linq;
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

        public IdentityRole Get(string id)
        {
            return dbSet.Find(id);
        }

        public void Update(IdentityRole role,string name)
        {
            IdentityRole objFromDb = _db.IdentityRoles.FirstOrDefault(s => s.Id == role.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = name;
            }
        }
    }
}
