using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListSerivceVM
    {
        public ListSerivceVM(List<Post> posts)
        {
            Posts = posts;
        }
        public List<Post> Posts { get; set; }
    }
}
