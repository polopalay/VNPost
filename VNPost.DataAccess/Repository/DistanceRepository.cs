using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class DistanceRepository : Repository<Distance>, IDistanceRepository
    {
        public DistanceRepository(ApplicationDbContext db) : base(db)
        {
        }
        public void Update(Distance distance)
        {
            Distance objFromDb = _db.Distances.FirstOrDefault(s => s.Id == distance.Id);
            if (objFromDb != null)
            {
                objFromDb.Range = distance.Range;
            }
        }
    }
}
