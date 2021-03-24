using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;
using VNPost.Utility;

namespace VNPost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : BaseController
    {
        [BindProperty]
        public Article Article { get; set; }
        [BindProperty]
        public string UserId { get; set; }

        public ArticleController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert([FromQuery] int id)
        {
            Article = _unitOfWork.Article.Get(id);
            return View(Article ?? new Article());
        }

        [HttpPost]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Article.Id == 0)
                {
                    Article.DateCreate = DateTime.Now;
                    _unitOfWork.Article.Add(Article);
                }
                else
                {
                    _unitOfWork.Article.Update(Article);
                }
                _unitOfWork.Save();
                return Redirect("/Admin/Article/Index");
            }
            return View(Article);
        }
    }
}
