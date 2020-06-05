using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;

namespace VNPost.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IDescriptionRepository Description { get; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Description = new DescriptionRepository(_db);
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
