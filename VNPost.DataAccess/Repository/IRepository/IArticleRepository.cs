using System;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IArticleRepository : IRepository<Article>
    {
        void Update(Article article);
    }
}
