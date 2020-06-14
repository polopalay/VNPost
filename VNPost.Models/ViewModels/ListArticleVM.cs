using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListArticleVM
    {
        public ListArticleVM(List<Columnist> columnist, Dictionary<string, string> listMenuItem, List<Article> articles)
        {
            Columnist = columnist;
            ListMenuItem = listMenuItem;
            Articles = articles;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public List<Columnist> Columnist { get; set; }
        public List<Article> Articles { get; set; }
    }
}
