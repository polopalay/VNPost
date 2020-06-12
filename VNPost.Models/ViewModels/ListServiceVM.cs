using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListSerivceVM
    {
        public ListSerivceVM(List<Post> posts, int begin, int end, int index, Category category)
        {
            Posts = posts;
            Begin = begin;
            End = end;
            Index = index;
            Category = category;
        }
        public List<Post> Posts { get; set; }
        public int Begin { get; set; }
        public int End { get; set; }
        public int Index { get; set; }
        public Category Category { get; set; }
    }
}
