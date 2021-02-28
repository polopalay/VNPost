using System;
using Microsoft.AspNetCore.Identity;

namespace VNPost.Models.ViewModels
{
    public class UserRole
    {
        public IdentityUser IdentityUser { get; set; }
        public IdentityRole IdentityRole { get; set; }
    }
}
