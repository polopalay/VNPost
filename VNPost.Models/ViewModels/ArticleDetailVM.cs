using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class ArticleDetailVM
    {
        public ArticleDetailVM(int columnistId, int columnistItemId)
        {
            ColumnistId = columnistId;
            ColumnistItemId = columnistItemId;
        }

        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
