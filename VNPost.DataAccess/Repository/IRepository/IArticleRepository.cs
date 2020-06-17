using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IArticleRepository : IRepository<Article>
    {
        void Update(Article article);
    }
}
