using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VNPost.Models.Entity
{
    public class MenuLocation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
