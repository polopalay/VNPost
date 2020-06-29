using System;
using Microsoft.AspNetCore.Identity;

namespace VNPost.Models.Entity
{
    public class UserRole
    {
        public IdentityUser IdentityUser { get; set; }
        public IdentityRole IdentityRole { get; set; }
    }
}
