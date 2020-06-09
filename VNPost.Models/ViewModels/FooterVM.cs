using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class FooterVM
    {
        public FooterVM(Dictionary<MenuLocation, List<MenuLink>> listMenuLink, List<MenuLocation> locations, Dictionary<string, string> listMenuItem)
        {
            ListMenuItem = listMenuItem;
            ListMenuLink = listMenuLink;
            Locations = locations;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public List<MenuLocation> Locations { get; set; }
        public Dictionary<MenuLocation, List<MenuLink>> ListMenuLink { get; set; }
    }
}
