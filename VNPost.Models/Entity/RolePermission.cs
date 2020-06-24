using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace VNPost.Models.Entity
{
    public class RolePermission
    {
        public RolePermission()
        {
        }

        public RolePermission(int columnistItemId, bool create, bool update, bool delete)
        {
            ColumnistItemId = columnistItemId;
            Create = create;
            Update = update;
            Delete = delete;
        }

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
