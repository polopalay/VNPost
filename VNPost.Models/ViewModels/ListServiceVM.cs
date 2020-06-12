using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListSerivceVM
    {
        public ListSerivceVM(List<Post> posts, int begin, int end, int index, int id)
        {
            Posts = posts;
            Begin = begin;
            End = end;
            Index = index;
            Id = id;
        }
        public List<Post> Posts { get; set; }
        public int Begin { get; set; }
        public int End { get; set; }
        public int Index { get; set; }
        public int Id { get; set; }
    }
}
