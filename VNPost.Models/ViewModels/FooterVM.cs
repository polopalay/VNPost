using System;
using System.Collections.Generic;
using System.Text;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class FooterVM
    {
        public FooterVM(List<Category> categories, List<Service> services)
        {
            Categories = categories;
            Services = services;
        }

        public List<Category> Categories { get; set; }
        public List<Service> Services { get; set; }
    }
}
