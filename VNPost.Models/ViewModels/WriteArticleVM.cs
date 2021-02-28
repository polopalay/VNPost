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
        public WriteArticleVM(Article article, List<Columnist> father, List<Columnist> son)
        {
            Article = article;
            Father = father;
            Son = son;
        }

        public Article Article { get; set; }
        public List<Columnist> Father { get; set; }
        public List<Columnist> Son { get; set; }
    }
}
