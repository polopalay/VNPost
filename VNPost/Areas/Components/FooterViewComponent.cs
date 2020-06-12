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
            List<MenuLink> links = _unitOfWork.MenuLink.GetAll().Where(l => l.LocationId == 8).ToList();
            List<Category> categories = _unitOfWork.Category.GetAll().Where(c => c.Id == 1 || c.Id == 2 || c.Id == 3).ToList();
            List<Post> posts = _unitOfWork.Post.GetAll().ToList();
            FooterVM footerVM = new FooterVM(listMenuItem, categories, posts, links);
            return View(footerVM);
        }
    }
}
