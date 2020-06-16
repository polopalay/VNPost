using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class WriteArticleVM
    {
        public WriteArticleVM()
        {
        }
        public WriteArticleVM(Article article, List<Columnist> columnists, List<ColumnistItem> columnistItems)
        {
            Article = article;
            Columnists = columnists;
            ColumnistItems = columnistItems;
        }

        public Article Article { get; set; }
        public List<Columnist> Columnists { get; set; }
        public List<ColumnistItem> ColumnistItems { get; set; }
    }
}
