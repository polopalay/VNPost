using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class CURDRepository : Repository<CURD>, ICURDRepository
    {
        private readonly ApplicationDbContext _db;

        public CURDRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
