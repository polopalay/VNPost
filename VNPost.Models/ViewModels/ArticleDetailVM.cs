using System;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ArticleDetailVM
    {
        public ArticleDetailVM(Article article, int columnistId, int columnistItemId)
        {
            Article = article;
            ColumnistId = columnistId;
            ColumnistItemId = columnistItemId;
        }

        public Article Article { get; set; }
        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
