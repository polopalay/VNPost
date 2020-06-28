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
    public class ManagerController : BaseController
    {
        public ManagerController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }
        public IActionResult Index()
        {
            var x = _unitOfWork.IdentityRole.GetAll();
            if (_identityRole == null)
            {
                return Forbid();
            }
            if (_identityRole.Id == "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
            {
                return View();
            }
            return Forbid();
        }

        public IActionResult Upsert()
        {
            if (_identityRole == null)
            {
                return Forbid();
            }
            if (!_identityRole.Equals("13d23c51-re38-4831-wqa2-2e3f21c23ewd"))
            {
                Forbid();
            }
            return View();
        }
    }
}
