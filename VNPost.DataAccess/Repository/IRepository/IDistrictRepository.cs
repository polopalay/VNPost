﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using VNPost.Models.Entity;

namespace VNPost.DataAccess.Repository.IRepository
{
    public interface IDistrictRepository : IRepository<District>
    {
        void Update(District article);
    }
}
