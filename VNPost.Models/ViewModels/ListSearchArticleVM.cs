using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ListSearchArticleVM
    {
        public ListSearchArticleVM(List<Article> articles)
        {
            Articles = articles;
        }

        public List<Article> Articles { get; set; }
        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
