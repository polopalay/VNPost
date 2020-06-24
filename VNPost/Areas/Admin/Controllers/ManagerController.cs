using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;

namespace VNPost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public ManagerController(UserManager<IdentityUser> userManager, IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
            }
            return View();
        }

        public IActionResult Upsert()
        {
            if (_signInManager.IsSignedIn(User))
            {
            }
            return View();
        }
    }
}
