using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Component.Controllers
{
    [Area("Component")]
    public class HeaderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HeaderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            Dictionary<string, string> listMenuItem = new Dictionary<string, string>();
            foreach (MenuItem menuItem in _unitOfWork.MenuItem.GetAll())
            {
                listMenuItem.Add(menuItem.Key, menuItem.Value);
            }
            Dictionary<int, List<MenuLink>> listMenuLink = new Dictionary<int, List<MenuLink>>();
            foreach(MenuLocation menuLocation in _unitOfWork.MenuLocation.GetAll())
            {
                List<MenuLink> links = new List<MenuLink>();
                foreach(MenuLink link in _unitOfWork.MenuLink.GetAll())
                {
                    if(link.LocationId==menuLocation.Id)
                    {
                        links.Add(link);
                    }
                }
                listMenuLink.Add(menuLocation.Id, links);
            }

            HeaderVM headerVM = new HeaderVM(listMenuItem, listMenuLink);
            return View(headerVM);
        }
    }
}