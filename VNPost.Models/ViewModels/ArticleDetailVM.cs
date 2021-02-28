using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ArticleDetailVM
    {
        public ArticleDetailVM(Article article, List<Article> articles, int columnistId, int columnistItemId)
        {
            Article = article;
            Articles = articles;
            ColumnistId = columnistId;
            ColumnistItemId = columnistItemId;
        }

        public Article Article { get; set; }
        public List<Article> Articles { get; set; }
        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
