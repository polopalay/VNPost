using System;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository
{
    public class ServiceDetailRepository : Repository<ServiceDetail>, IServiceDetailRepository
    {
        public ServiceDetailRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
