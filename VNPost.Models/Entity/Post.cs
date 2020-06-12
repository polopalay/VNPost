using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionImg { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        [ForeignKey("CategoryId")]
        public Gallery Gallery = new Gallery();
    }
}
