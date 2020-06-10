using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HomeVM
    {
        public HomeVM(List<MenuLink> links)
        {
            Links = links;
        }

        public List<MenuLink> Links { get; set; }
    }
}
