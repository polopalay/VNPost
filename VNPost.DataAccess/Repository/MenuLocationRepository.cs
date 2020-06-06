using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    class MenuLocationRepository : Repository<MenuLocation>, IMenuLocationRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuLocationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
