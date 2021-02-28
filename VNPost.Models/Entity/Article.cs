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

        public Article(int id, string title, string description, string author, int columnistId, string descriptionImg, string content)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            ColumnistId = columnistId;
            DescriptionImg = descriptionImg;
            Content = content;
        }

        Article(int id, string title, string description, string descriptionImg, Columnist columnist, int columnistId, DateTime dateCreate)
        {
            Id = id;
            Title = title;
            Description = description;
            DescriptionImg = descriptionImg;
            Columnist = columnist;
            ColumnistId = columnistId;
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
        public int ColumnistId { get; set; }
        [ForeignKey("ColumnistId")]
        public Columnist Columnist { get; set; }
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
            return new Article(Id, Title, Description, DescriptionImg, Columnist, ColumnistId, DateCreate);
        }
        public Article LiteArticle()
        {
            return new Article(Id, Title, Author, DateCreate);
        }
    }
}
