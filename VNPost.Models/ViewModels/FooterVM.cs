using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class FooterVM
    {
        public FooterVM(Dictionary<string, string> listMenuItem, List<Category> categories, List<Post> posts, List<MenuLink> links)
        {
            ListMenuItem = listMenuItem;
            Categories = categories;
            Links = links;
            Posts = posts;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public List<MenuLink> Links { get; set; }
        public List<Category> Categories { get; set; }
        public List<Post> Posts { get; set; }
    }
}
