using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            MenuLocation location = _unitOfWork.MenuLocation.Get(10);
            List<MenuLink> links = _unitOfWork.MenuLink.GetAll().Where(link => link.LocationId == 9 || link.LocationId == location.Id).ToList();
            List<Gallery> galleries = _unitOfWork.Gallery.GetAll().ToList();
            List<Article> articles = _unitOfWork.Article.GetAll().ToList();
            List<Category> categories = _unitOfWork.Category.GetAll().Where(c => c.Id == 1 || c.Id == 2 || c.Id == 3).ToList();
            List<Post> posts = _unitOfWork.Post.GetAll().ToList();
            MenuItem item = _unitOfWork.MenuItem.Get(12);

            HomeVM homeVM = new HomeVM(links, galleries, articles, categories, posts, location, item);
            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
