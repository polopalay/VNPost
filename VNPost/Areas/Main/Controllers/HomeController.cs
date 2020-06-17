using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HomeController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            MenuLocation location = _unitOfWork.MenuLocation.Get(10);
            List<MenuLink> links = _unitOfWork.MenuLink.GetAll().Where(link => link.LocationId == 9 || link.LocationId == location.Id).ToList();
            List<Gallery> galleries = _unitOfWork.Gallery.GetAll().ToList();
            List<Category> categories = _unitOfWork.Category.GetAll().ToList();
            List<Post> posts = _unitOfWork.Post.GetAll().ToList();
            MenuItem item = _unitOfWork.MenuItem.Get(12);
            List<Article> articles = _unitOfWork.Article
                .GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate))
                .Select(a=>a.SoftArticle())
                .Take(5).ToList();
            HomeVM homeVM = new HomeVM(links, galleries, categories, posts, location, item, articles);
            return View(homeVM);
        }
    }
}
