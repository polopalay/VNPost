using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Posts.Controllers
{
    [Area("Posts")]
    public class WriteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        public WriteController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }
        public IActionResult WriteArticle()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                List<Columnist> columnists = _unitOfWork.Columnist.GetAll().ToList();
                List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
                Article article = new Article();
                WriteArticleVM writeArticleVM = new WriteArticleVM(article, columnists, columnistItems);
                return View(writeArticleVM);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WriteArticle(Article article)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            string s = "";
            string rawText = "data:image/";
            int begin = article.Content.IndexOf(rawText);
            if (begin != -1)
            {
                s = article.Content;
                s = s.Substring(begin, s.IndexOf('"', begin + rawText.Length) - begin);
            }
            else
            {
                rawText = "src=\"";
                begin = article.Content.IndexOf(rawText);
                if (begin != -1)
                {
                    s = article.Content;
                    s = s.Substring(begin + 5, s.IndexOf('"', begin + rawText.Length) - begin);
                }
            }
            article.DescriptionImg = s;
            article.DateCreate = DateTime.Now;
            article.View = 0;
            _unitOfWork.Article.Add(article);
            _unitOfWork.Save();
            return Redirect("/Posts/Article/List");
        }
    }
}
