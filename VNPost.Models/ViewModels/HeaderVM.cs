using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HeaderVM
    {
        public HeaderVM(Dictionary<string, string> listMenuItem, Dictionary<int, List<MenuLink>> listMenuLink)
        {
            ListMenuItem = listMenuItem;
            ListMenuLink = listMenuLink;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public Dictionary<int, List<MenuLink>> ListMenuLink { get; set; }
    }
}
