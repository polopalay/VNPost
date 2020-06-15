using System;
using System.Collections.Generic;
using VNPost.Models.Entity;

namespace VNPost.Models.ViewModels
{
    public class LeftVM
    {
        public LeftVM(List<Columnist> columnist, List<ColumnistItem> columnistItem, Dictionary<string, string> listMenuItem,
           int columnistId, int columnistItemId)
        {
            Columnist = columnist;
            ListMenuItem = listMenuItem;
            ColumnistItem = columnistItem;
            ColumnistId = columnistId;
            ColumnistItemId = columnistItemId;
        }

        public Dictionary<string, string> ListMenuItem { get; set; }
        public List<Columnist> Columnist { get; set; }
        public List<ColumnistItem> ColumnistItem { get; set; }
        public int ColumnistId { get; set; }
        public int ColumnistItemId { get; set; }
    }
}
