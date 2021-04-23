using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Utility;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : BaseApiController
    {
        public DistanceController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int start, int end)
        {
            List<Distance> distances = _unitOfWork.Distance.GetAll(filter: d => (d.StartID == start && d.EndID == end) || (d.EndID == start && d.StartID == end)).ToList();
            return Ok(distances.Count > 0 ? distances[0] : new Distance() { StartID = start, EndID = end });
        }
    }
}