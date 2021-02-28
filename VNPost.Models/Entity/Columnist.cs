using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VNPost.Models.Entity
{
    public class Columnist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FatherId { get; set; }
    }
}
