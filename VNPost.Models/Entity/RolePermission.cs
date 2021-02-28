using System;
using System.ComponentModel.DataAnnotations;
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
            ColumnistId = columnistItemId;
            Create = create;
            Update = update;
            Delete = delete;
        }

        public int Id { get; set; }
        public string RoleId { get; set; }
        [ForeignKey("RoleId")]
        public IdentityRole Role { get; set; }
        [Required]
        public int ColumnistId { get; set; }
        [ForeignKey("ColumnistId")]
        public Columnist Columnist { get; set; }
        [Required]
        public bool Create { get; set; }
        [Required]
        public bool Update { get; set; }
        [Required]
        public bool Delete { get; set; }
    }
}
