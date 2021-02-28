using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;
using VNPost.Utility;

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
        public IActionResult List(int id, [FromQuery] int index)
        {
            if (index == 0)
            {
                index = 1;
            }
            Category category = _unitOfWork.Category.Get(id);
            if (category == null)
            {
                return Redirect("/");
            }
            List<Post> posts = _unitOfWork.Post.GetAll()
                .Where(p => p.CategoryId == id)
                .ToList();
            int numberPostInPage = 6;
            Pagination<Post> pagination = new Pagination<Post>(posts, index, numberPostInPage);
            ListSerivceVM listSerivce = new ListSerivceVM(pagination.ListT, pagination.Begin, pagination.End, index, category);
            return View(listSerivce);
        }

        public IActionResult ServiceDetail(int id)
        {
            Post post = _unitOfWork.Post.Get(id);
            if (post == null)
            {
                return Redirect("/");
            }
            List<Service> service = _unitOfWork.Service.GetAll().Where(s => s.PostId == post.Id).ToList();
            ServiceDetailVM serviceDetail = new ServiceDetailVM(post, service);
            return View(serviceDetail);
        }
    }
}
