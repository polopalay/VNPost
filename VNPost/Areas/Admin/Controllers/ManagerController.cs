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
        private readonly SignInManager<IdentityUser> _signInManager;
        public ManagerController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;
                    
                    if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
                    {
                        return Forbid();
                    }
                }
                else
                {
                    return Forbid();
                }
            }
            else
            {
                return Forbid();
            }
            return View();
        }

        public IActionResult Upsert()
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                    if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
                    {
                        return Forbid();
                    }
                }
                else
                {
                    return Forbid();
                }
            }
            else
            {
                return Forbid();
            }
            return View();
        }
    }
}
