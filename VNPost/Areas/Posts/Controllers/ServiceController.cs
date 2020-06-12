using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.Areas.Posts.Controllers
{
    [Area("Posts")]
    public class ServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult List(int id)
        {
            List<Post> posts = _unitOfWork.Post.GetAll().Where(p => p.CategoryId == id).ToList();
            return View(posts);
        }
    }
}
