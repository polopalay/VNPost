using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
    }
}
