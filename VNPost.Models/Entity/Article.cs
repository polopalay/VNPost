using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VNPost.Models.Entity
{
    public class Article
    {
        public Article()
        {
        }
        public Article(int id, string title, string description, string descriptionImg, ColumnistItem columnistItem, int columnistItemId, DateTime dateCreate)
        {
            Id = id;
            Title = title;
            Description = description;
            DescriptionImg = descriptionImg;
            ColumnistItem = columnistItem;
            ColumnistItemId = columnistItemId;
            DateCreate = dateCreate;
        }
        public Article(int id, string title, DateTime dateCreate)
        {
            Id = id;
            Title = title;
            DateCreate = dateCreate;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionImg { get; set; }
        public DateTime DateCreate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int View { get; set; }
        public int ColumnistItemId { get; set; }
        [ForeignKey("ColumnistItemId")]
        public ColumnistItem ColumnistItem { get; set; }

        public string SoftDescription()
        {
            return Description.Length > 150 ? (Description.Substring(0, 150) + "...") : Description;
        }

        public Article SoftArticle()
        {
            return new Article(Id, Title, Description, DescriptionImg, ColumnistItem, ColumnistItemId, DateCreate);
        }
        public Article LiteArticle()
        {
            return new Article(Id, Title, DateCreate);
        }
    }
}
