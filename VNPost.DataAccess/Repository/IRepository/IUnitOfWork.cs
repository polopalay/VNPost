using System;
using System.Collections.Generic;
using System.Text;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IDescriptionRepository Description { get; }
        void Save();
    }
}
