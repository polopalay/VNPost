using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace VNPost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegisterTypeUserController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public RegisterTypeUserController(SignInManager<IdentityUser> signInManager)
        {
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
    }
}
