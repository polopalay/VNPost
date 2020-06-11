using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HomeVM
    {
        public HomeVM(List<MenuLink> links, List<Gallery> galleries)
        {
            Links = links;
            Galleries = galleries;
        }

        public List<MenuLink> Links { get; set; }
        public List<Gallery> Galleries { get; set; }
    }
}
