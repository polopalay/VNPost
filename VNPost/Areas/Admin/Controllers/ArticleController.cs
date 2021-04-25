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
        private readonly UserManager<IdentityUser> _userManager;

        public ArticleController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager) : base(unitOfWork, signInManager)
        {
            _userManager = userManager;
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
        public async Task<IActionResult> Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Article.Id == 0)
                {
                    Article.DescriptionImg = Article.DescriptionImg ?? "/image/post/logoVNPost.png";
                    Article.DateCreate = DateTime.Now;
                    Article.Accepted = false;
                    Article.IdentityUserId = (await _userManager.GetUserAsync(User)).Id;
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

        public IActionResult Censor([FromQuery] int id)
        {
            _unitOfWork.Columnist.GetAll();
            return View(_unitOfWork.Article.GetAll(filter: a => a.Accepted == false));
        }

        [HttpPost]
        public IActionResult Censor()
        {
            Article article = _unitOfWork.Article.Get(Article.Id);
            if (Article.Accepted)
            {
                article.Accepted = true;
                _unitOfWork.Article.Update(article);
            }
            else
            {
                _unitOfWork.Article.Remove(article);
            }
            _unitOfWork.Save();
            _unitOfWork.Columnist.GetAll();
            return View(_unitOfWork.Article.GetAll(filter: a => a.Accepted == false));
        }
    }
}
