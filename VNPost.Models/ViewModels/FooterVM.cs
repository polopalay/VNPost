using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class FooterVM
    {
        public FooterVM(List<Category> categories, List<Post> posts)
        {
            Categories = categories;
            Posts = posts;
        }

        public List<Category> Categories { get; set; }
        public List<Post> Posts { get; set; }
    }
}
