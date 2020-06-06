using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    class MenuLinkRepository:Repository<MenuLink>,IMenuLinkRepository
    {
        private readonly ApplicationDbContext _db;

        public MenuLinkRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
