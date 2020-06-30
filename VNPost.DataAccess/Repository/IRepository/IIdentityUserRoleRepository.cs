using System;
using Microsoft.AspNetCore.Identity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IIdentityUserRoleRepository : IRepository<IdentityUserRole<string>>
    {
        void Remove(string uid,string rid);
    }
}
