using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionImg { get; set; }
        public DateTime DateCreate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int View { get; set; }
        public int GalleryId { get; set; }
        [ForeignKey("GalleryId")]
        public Gallery Gallery = new Gallery();
        public int ColumnistId { get; set; }
        [ForeignKey("ColumnistId")]
        public Columnist Columnist { get; set; }
        public string SoftDescription()
        {
            return Description.Length > 150 ? (Description.Substring(0, 150) + "...") : Description;
        }
    }
}
