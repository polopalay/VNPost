using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Components
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public FooterViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            Dictionary<string, string> listMenuItem = new Dictionary<string, string>();
            foreach (MenuItem menuItem in _unitOfWork.MenuItem.GetAll())
            {
                listMenuItem.Add(menuItem.Key, menuItem.Value);
            }
            Dictionary<MenuLocation, List<MenuLink>> listMenuLink = new Dictionary<MenuLocation, List<MenuLink>>();
            List<MenuLocation> locations = new List<MenuLocation>();
            foreach (MenuLocation menuLocation in _unitOfWork.MenuLocation.GetAll())
            {
                List<MenuLink> links = _unitOfWork.MenuLink.GetAll(link => link.LocationId == menuLocation.Id).ToList();
                listMenuLink.Add(menuLocation, links);
                if (menuLocation.Id == 5 || menuLocation.Id == 6 || menuLocation.Id == 7 || menuLocation.Id == 8)
                {
                    locations.Add(menuLocation);
                }
            }
            FooterVM footerVM = new FooterVM(listMenuLink, locations, listMenuItem);
            return View(footerVM);
        }
    }
}
