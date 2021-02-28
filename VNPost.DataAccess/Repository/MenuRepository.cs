using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    class MenuRepository:Repository<Menu>,IMenuRepository
    {
        public MenuRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
