﻿using System;
using Microsoft.AspNetCore.Identity;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;

namespace VNPost.DataAccess.Repository
{
    public class IdentityUserRoleRepository : Repository<IdentityUserRole<string>>, IIdentityUserRoleRepository
    {
        public IdentityUserRoleRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Remove(string uid, string rid)
        {
            IdentityUserRole<string> entity = dbSet.Find(uid, rid);
            Remove(entity);
        }
    }
}
