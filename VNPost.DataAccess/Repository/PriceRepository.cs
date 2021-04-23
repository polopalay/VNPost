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
    public class PriceRepository : Repository<Price>, IPriceRepository
    {
        public PriceRepository(ApplicationDbContext db) : base(db)
        {
        }
        public void Update(Price price)
        {
            Price objFromDb = _db.Prices.FirstOrDefault(s => s.Id == price.Id);
            if (objFromDb != null)
            {
                objFromDb.Distance = price.Distance;
                objFromDb.Size = price.Size;
                objFromDb.Weight = price.Weight;
            }
        }
    }
}
