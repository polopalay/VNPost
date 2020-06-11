﻿using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;

namespace VNPost.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IMenuItemRepository MenuItem { get; }
        public IMenuLocationRepository MenuLocation { get; }
        public IMenuLinkRepository MenuLink { get; }
        public IGalleryRepository Gallery { get; }
        public IArticleRepository Article { get; }
        public ICategoryRepository Category { get; }
        public IPostRepository Post { get; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            MenuItem = new MenuItemRepository(_db);
            MenuLocation = new MenuLocationRepository(_db);
            MenuLink = new MenuLinkRepository(_db);
            Gallery = new GalleryRepository(_db);
            Article = new ArticleRepository(_db);
            Category = new CategoryRepository(_db);
            Post = new PostRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
