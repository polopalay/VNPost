using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListArticleVM
    {
        public ListArticleVM(List<Columnist> columnist, Dictionary<string, string> listMenuItem)
        {
            Columnist = columnist;
            ListMenuItem = listMenuItem;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public List<Columnist> Columnist { get; set; }
    }
}
