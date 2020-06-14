using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class ColumnistRepository : Repository<Columnist>, IColumnistRepository
    {
        private readonly ApplicationDbContext _db;

        public ColumnistRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
