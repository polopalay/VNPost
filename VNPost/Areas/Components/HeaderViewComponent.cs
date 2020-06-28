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
            Dictionary<string, string> listMenuItem = new Dictionary<string, string>();
            foreach (MenuItem menuItem in _unitOfWork.MenuItem.GetAll())
            {
                listMenuItem.Add(menuItem.Key, menuItem.Value);
            }
            Dictionary<int, List<MenuLink>> listMenuLink = new Dictionary<int, List<MenuLink>>();
            foreach (MenuLocation menuLocation in _unitOfWork.MenuLocation.GetAll())
            {
                List<MenuLink> links = _unitOfWork.MenuLink.GetAll(link => link.LocationId == menuLocation.Id).ToList();
                listMenuLink.Add(menuLocation.Id, links);
            }

            List<Category> categories = _unitOfWork.Category.GetAll().ToList();

            HeaderVM headerVM = new HeaderVM(listMenuItem, listMenuLink, categories);
            headerVM.IsLogedIn = _signInManager.IsSignedIn((ClaimsPrincipal)User);
            return View(headerVM);
        }
    }
}
