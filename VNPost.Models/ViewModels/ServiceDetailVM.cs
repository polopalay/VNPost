using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ServiceDetailVM
    {
        public ServiceDetailVM(Post post, List<Service> service)
        {
            Post = post;
            Service = service;
        }
        public Post Post { get; set; }
        public List<Service> Service { get; set; }
    }
}
