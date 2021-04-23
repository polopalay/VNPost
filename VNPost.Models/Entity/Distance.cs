using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Distance
    {
        public int Id { get; set; }
        public int StartID { get; set; }
        public int EndID { get; set; }
        public int Range { get; set; }
    }
}
