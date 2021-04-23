using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;
using VNPost.Utility;

namespace VNPost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DistanceController : BaseController
    {
        [BindProperty]
        public Distance Distance { get; set; }

        public DistanceController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        public IActionResult Index([FromQuery] int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index()
        {
            List<Distance> distances = _unitOfWork.Distance.GetAll(filter: d =>
            (d.StartID == Distance.StartID && d.EndID == Distance.EndID)
            || (d.StartID == Distance.EndID && d.EndID == Distance.StartID)).ToList();
            if (distances.Count > 0)
            {
                Distance.Range = distances[0].Range;
                _unitOfWork.Distance.Update(Distance);
            }
            else
            {
                _unitOfWork.Distance.Add(Distance);
            }
            _unitOfWork.Save();
            return View(Distance);
        }
    }
}