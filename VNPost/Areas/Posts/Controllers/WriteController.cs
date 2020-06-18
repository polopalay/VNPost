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

namespace VNPost.Areas.Posts.Controllers
{
    [Area("Posts")]
    public class WriteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly SignInManager<IdentityUser> _signInManager;

        public WriteController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _hostEnvironment = hostEnvironment;
        }
        public IActionResult Index(int index)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                List<Article> articles = _unitOfWork.Article.GetAll(orderBy:x=>x.OrderByDescending(y=>y.DateCreate)).ToList();
                if (index == 0)
                {
                    index = 1;
                }
                int numberPostInPage = 10;
                Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
                ListSearchArticleVM articleVM = new ListSearchArticleVM(pagination.ListT)
                {
                    Begin = pagination.Begin,
                    End = pagination.End,
                    Index = index
                };
                return View(articleVM);
            }
        }
        public IActionResult Upsert(int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                List<Columnist> columnists = _unitOfWork.Columnist.GetAll().ToList();
                List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
                if (id == 0)
                {
                    Article article = new Article();
                    WriteArticleVM writeArticleVM = new WriteArticleVM(article, columnists, columnistItems);
                    return View(writeArticleVM);
                }
                else
                {
                    Article article = _unitOfWork.Article.Get(id);
                    article.Id = id;
                    WriteArticleVM writeArticleVM = new WriteArticleVM(article, columnists, columnistItems);
                    return View(writeArticleVM);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Article article)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            string s = "";
            if (article.Content != null)
            {
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
            }
            if (article.Id == 0)
            {
                article.DescriptionImg = s;
                article.DateCreate = DateTime.Now;
                article.View = 0;
                _unitOfWork.Article.Add(article);
            }
            else
            {
                if (s != "")
                {
                    article.DescriptionImg = s;
                }
                _unitOfWork.Article.Update(article);
            }

            _unitOfWork.Save();
            return Redirect("/Posts/Write/Index");
        }

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Article.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Article.Remove(objFromDb);
            _unitOfWork.Save();
            return Redirect("/Posts/Write/Index");

        }
    }
}
