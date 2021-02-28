using System;
using System.Collections.Generic;
using System.Linq;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HomeVM
    {
        public HomeVM(List<Banner> banners, List<Category> categories,
            List<Post> posts, List<Article> articles)
        {
            Banners = banners;
            Categories = categories;
            Posts = posts;
            Articles = articles;
        }

        public List<Banner> Banners { get; set; }
        public List<Category> Categories { get; set; }
        public List<Post> Posts { get; set; }
        public List<Article> Articles { get; set; }
    }
}
