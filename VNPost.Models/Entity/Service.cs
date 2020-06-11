using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Service
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post = new Post();
    }
}
