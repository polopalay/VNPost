using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class HeaderVM
    {
        public HeaderVM(List<Menu> menus, List<Category> categories)
        {
            Menus = menus;
            Categories = categories;
        }

        public bool IsLogedIn { get; set; }
        public List<Menu> Menus { get; set; }
        public List<Category> Categories { get; set; }
        public string Name { get; set; }
    }
}
