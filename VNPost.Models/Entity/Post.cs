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
        public int GalleryId { get; set; }
        [ForeignKey("GalleryId")]
        public Gallery Gallery = new Gallery();
        public string SoftDescription()
        {
            return Description.Length > 150 ? (Description.Substring(0, 150) + "...") : Description;
        }
    }
}
