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
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        public ProvinceRepository(ApplicationDbContext db) : base(db)
        {
        }
        public void Update(Province article)
        {
            Province objFromDb = _db.Provinces.FirstOrDefault(s => s.Id == article.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = article.Name;
            }
        }
    }
}
