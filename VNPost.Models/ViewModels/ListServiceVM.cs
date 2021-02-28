using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListSerivceVM
    {
        public ListSerivceVM(List<Service> services, int begin, int end, int index, Category category)
        {
            Services = services;
            Begin = begin;
            End = end;
            Index = index;
            Category = category;
        }
        public List<Service> Services { get; set; }
        public int Begin { get; set; }
        public int End { get; set; }
        public int Index { get; set; }
        public Category Category { get; set; }
    }
}
