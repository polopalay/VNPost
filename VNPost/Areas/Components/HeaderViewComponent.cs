using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HeaderViewComponent(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }
        public IViewComponentResult Invoke()
        {
            List<Category> categories = _unitOfWork.Category.GetAll().ToList();

            HeaderVM headerVM = new HeaderVM(_unitOfWork.Menu.GetAll().ToList(), categories)
            {
                IsLogedIn = _signInManager.IsSignedIn((ClaimsPrincipal)User),
                Name = User.Identity.Name
            };
            return View(headerVM);
        }
    }
}
