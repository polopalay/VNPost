using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class ColumnistItemRepository : Repository<ColumnistItem>, IColumnistItemRepository
    {
        public ColumnistItemRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
