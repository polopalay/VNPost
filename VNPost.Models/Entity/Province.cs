using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace VNPost.Models.Entity
{
    public class Province
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
