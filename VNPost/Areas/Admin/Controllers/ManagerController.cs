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
        public ManagerController(UserManager<IdentityUser> userManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> IndexAsync()
        {
            IdentityUser userName = await _userManager.FindByEmailAsync(User.Identity.Name);
            List<IdentityRole> roles = _unitOfWork.IdentityRole.GetAll().ToList();
            List<IdentityUserRole<string>> userRoles = _unitOfWork.IdentityUserRole.GetAll().ToList();
            List<IdentityUser> user = _unitOfWork.IdentityUser.GetAll().ToList();
            return View();
        }
    }
}
