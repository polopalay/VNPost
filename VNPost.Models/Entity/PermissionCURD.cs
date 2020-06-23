using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class PermissionCURD
    {
        public int RolePermissionId { get; set; }
        [ForeignKey("RolePermissionId")]
        public RolePermission RolePermission { get; set; }
        public int CRUDId { get; set; }
        [ForeignKey("CURDId")]
        public CURD ColumnistItem { get; set; }
    }
}
