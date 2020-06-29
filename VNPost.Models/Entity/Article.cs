using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace VNPost.Models.Entity
{
    public class Article
    {
        public Article()
        {
        }

        public Article(string title, string description, string author, string descriptionImg, string content)
        {
            Title = title;
            Description = description;
            Author = author;
            DescriptionImg = descriptionImg;
            Content = content;
        }

        public Article(int id, string title, string description, string author, int columnistItemId, string descriptionImg, string content)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            ColumnistItemId = columnistItemId;
            DescriptionImg = descriptionImg;
            Content = content;
        }

        Article(int id, string title, string description, string descriptionImg, ColumnistItem columnistItem, int columnistItemId, DateTime dateCreate)
        {
            Id = id;
            Title = title;
            Description = description;
            DescriptionImg = descriptionImg;
            ColumnistItem = columnistItem;
            ColumnistItemId = columnistItemId;
            DateCreate = dateCreate;
        }

        Article(int id, string title, string auhtor, DateTime dateCreate)
        {
            Id = id;
            Title = title;
            Author = auhtor;
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
        public string IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        private IdentityUser identityUser;
        public IdentityUser IdentityUser
        {
            get
            {
                if (identityUser == null) { return identityUser; }
                else { return new IdentityUser(identityUser.UserName); }
            }
            set { identityUser = value; }
        }

        public string SoftDescription()
        {
            if (Description == null)
            {
                return "";
            }
            else
            {
                return Description.Length > 150 ? (Description.Substring(0, 150) + "...") : Description;
            }
        }

        public Article SoftArticle()
        {
            return new Article(Id, Title, Description, DescriptionImg, ColumnistItem, ColumnistItemId, DateCreate);
        }
        public Article LiteArticle()
        {
            return new Article(Id, Title, Author, DateCreate);
        }
    }
}
