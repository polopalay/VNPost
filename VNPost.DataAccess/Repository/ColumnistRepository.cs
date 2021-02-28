using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class ColumnistRepository : Repository<Columnist>, IColumnistRepository
    {
        public ColumnistRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
