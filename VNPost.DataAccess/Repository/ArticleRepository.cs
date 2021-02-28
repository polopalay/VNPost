using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext db) : base(db)
        {
        }
        public void Update(Article article)
        {
            Article objFromDb = _db.Articles.FirstOrDefault(s => s.Id == article.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = article.Title;
                objFromDb.Description = article.Description;
                objFromDb.DescriptionImg = article.DescriptionImg;
                objFromDb.DateCreate = article.DateCreate;
                objFromDb.Author = article.Author;
                objFromDb.Content = article.Content;
                objFromDb.View = article.View;
                objFromDb.ColumnistId = article.ColumnistId;
            }
        }
    }
}
