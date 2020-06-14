using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int View { get; set; }
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public int ColumnistId { get; set; }
        [ForeignKey("ColumnistId")]
        public Columnist Columnist { get; set; }
    }
}
