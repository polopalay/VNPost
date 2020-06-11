using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class GalleryRepository : Repository<Gallery>, IGalleryRepository
    {
        private readonly ApplicationDbContext _db;

        public GalleryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
