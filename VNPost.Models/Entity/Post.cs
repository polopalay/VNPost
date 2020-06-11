using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public Gallery Gallery = new Gallery();
    }
}
