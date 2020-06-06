﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VNPost.Models.Entity
{
    public class MenuLink
    {
        [Key]
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Link { get; set; }
        [Required]
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public MenuLocation MenuLocation { get; set; }
    }
}
