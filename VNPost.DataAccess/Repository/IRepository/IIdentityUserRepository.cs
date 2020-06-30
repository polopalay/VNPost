using System;
using Microsoft.AspNetCore.Identity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IIdentityUserRepository : IRepository<IdentityUser>
    {
        IdentityUser Get(string id);
        void Remove(string id);
    }
}
