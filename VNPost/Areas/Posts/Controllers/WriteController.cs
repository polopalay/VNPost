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

namespace VNPost.Areas.Posts.Controllers
{
    [Area("Posts")]
    public class WriteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;

        public WriteController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
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

        public IActionResult Upsert()
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
    }
}
