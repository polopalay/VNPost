using System;
using System.Collections.Generic;
using System.Text;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IMenuItemRepository MenuItem { get; }
        IMenuLocationRepository MenuLocation { get; }
        IMenuLinkRepository MenuLink { get; }
        void Save();
    }
}
