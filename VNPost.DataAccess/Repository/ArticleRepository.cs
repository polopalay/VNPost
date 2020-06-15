﻿using System;
using System.Linq;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
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
                objFromDb.ColumnistItemId = article.ColumnistItemId;
            }
        }
    }
}
