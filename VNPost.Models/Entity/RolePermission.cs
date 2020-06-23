using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace VNPost.Models.Entity
{
    public class RolePermission
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        [ForeignKey("RoleId")]
        public IdentityRole Role { get; set; }
        public int ColumnistItemId { get; set; }
        [ForeignKey("ColumnistItemId")]
        public ColumnistItem ColumnistItem { get; set; }
        public bool Create { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
