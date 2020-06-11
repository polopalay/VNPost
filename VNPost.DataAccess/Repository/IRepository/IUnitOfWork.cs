﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IMenuItemRepository MenuItem { get; }
        IMenuLocationRepository MenuLocation { get; }
        IMenuLinkRepository MenuLink { get; }
        IGalleryRepository Gallery { get; }
        IArticleRepository Article { get; }
        ICategoryRepository Category { get; }
        IPostRepository Post { get; }
        void Save();
    }
}
