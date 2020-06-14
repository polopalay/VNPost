using System;
using System.Collections.Generic;
using System.Linq;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HomeVM
    {
        public HomeVM(List<MenuLink> links, List<Gallery> galleries, List<Category> categories,
            List<Post> posts, MenuLocation location, MenuItem item, List<Article> articles)
        {
            Links = links;
            Galleries = galleries;
            Categories = categories;
            Posts = posts;
            Location = location;
            Item = item;
            Articles = articles;
        }

        public List<MenuLink> Links { get; set; }
        public List<Gallery> Galleries { get; set; }
        public List<Category> Categories { get; set; }
        public List<Post> Posts { get; set; }
        public List<Article> Articles { get; set; }
        public MenuLocation Location { get; set; }
        public MenuItem Item { get; set; }
    }
}
