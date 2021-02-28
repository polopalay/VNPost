using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class LeftVM
    {
        public LeftVM(List<Columnist> columnist, List<ColumnistItem> columnistItem,
           int columnistId, int columnistItemId)
        {
            Columnist = columnist;
            ColumnistItem = columnistItem;
            ColumnistId = columnistId;
            ColumnistItemId = columnistItemId;
        }

        public List<Columnist> Columnist { get; set; }
        public List<ColumnistItem> ColumnistItem { get; set; }
        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
