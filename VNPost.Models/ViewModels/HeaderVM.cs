using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HeaderVM
    {
        public HeaderVM(Dictionary<string, string> listMenuItem, Dictionary<int, List<MenuLink>> listMenuLink, List<Category> categories)
        {
            ListMenuItem = listMenuItem;
            ListMenuLink = listMenuLink;
            Categories = categories;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public Dictionary<int, List<MenuLink>> ListMenuLink { get; set; }
        public List<Category> Categories { get; set; }
    }
}
