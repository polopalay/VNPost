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
    public class ParcelRepository : Repository<Parcel>, IParcelRepository
    {
        private readonly ApplicationDbContext _db;

        public ParcelRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Parcel article)
        {
            Parcel objFromDb = _db.Parcels.FirstOrDefault(s => s.Id == article.Id);
            if (objFromDb != null)
            {
                objFromDb.Items = article.Items;
                objFromDb.PointAway = article.PointAway;
                objFromDb.Destination = article.Destination;
                objFromDb.StatusId = article.StatusId;
                objFromDb.CustomerInfo = article.CustomerInfo;
                objFromDb.OtherInfo = article.OtherInfo;
            }
        }
    }
}
