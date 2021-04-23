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
    public class PriceController : BaseController
    {
        [BindProperty]
        public Price Price { get; set; }

        public PriceController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        public IActionResult Index([FromQuery] int id)
        {
            Price = _unitOfWork.Price.Get(1);
            return View(Price);
        }

        [HttpPost]
        public IActionResult Index()
        {
            _unitOfWork.Price.Update(Price);
            _unitOfWork.Save();
            return View(Price);
        }
    }
}
