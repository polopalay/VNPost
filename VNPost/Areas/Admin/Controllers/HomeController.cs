using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : BaseController
    {
        [BindProperty]
        public Location Marker { get; set; }
        public HomeController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                return View();
            }
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            Marker = new Location() { ParcelId = id };
            return View(Marker);
        }

        [HttpPost]
        public IActionResult Edit()
        {
            Marker.Id = 0;
            _unitOfWork.Location.Add(Marker);
            _unitOfWork.Save();
            return Redirect("/Admin/Home/Edit/" + Marker.ParcelId);
        }
    }
}
