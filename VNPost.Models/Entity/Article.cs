using System;
namespace VNPost.Models.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionImg { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
