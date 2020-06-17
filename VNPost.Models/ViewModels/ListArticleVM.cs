using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListArticleVM
    {
        public ListArticleVM(List<Columnist> columnist, List<ColumnistItem> columnistItem, List<Article> articles)
        {
            Columnist = columnist;
            Articles = articles;
            ColumnistItem = columnistItem;
        }

        public List<Columnist> Columnist { get; set; }
        public List<ColumnistItem> ColumnistItem { get; set; }
        public List<Article> Articles { get; set; }
        public List<Article> MostNewArticles { get; set; }
        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
