﻿using System;
using Microsoft.AspNetCore.Identity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IIdentityRoleRepository : IRepository<IdentityRole>
    {
        IdentityRole Get(string id);
        void Update(IdentityRole article,string name);
    }
}
