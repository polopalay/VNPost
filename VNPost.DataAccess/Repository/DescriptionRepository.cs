using System;
using System.Collections.Generic;
using System.Text;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.ClassModels;

namespace VNPost.DataAccess.Repository
{
    public class DescriptionRepository: Repository<Description>, IDescriptionRepository
    {
        private readonly ApplicationDbContext _db;

        public DescriptionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
