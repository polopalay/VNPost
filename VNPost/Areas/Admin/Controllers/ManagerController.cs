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
            if (IsAdmin())
            {
                return View();
            }
            else
            {
                return Forbid();
            }
        }

        public IActionResult Upsert()
        {
            if (IsAdmin())
            {
                return View();
            }
            else
            {
                return Forbid();
            }
        }
    }
}
