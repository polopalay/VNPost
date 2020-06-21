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
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult ListColumnist([FromQuery] int columnistId, [FromQuery] int columnistItemId)
        {
            ListSearchArticleVM articleVM = new ListSearchArticleVM()
            {
                ColumnistId = columnistId,
                ColumnistItemId = columnistItemId,
            };
            return View(articleVM);
        }

        public IActionResult ArticleDetail(int id)
        {
            List<Columnist> columnists = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            Article article = _unitOfWork.Article.Get(id);
            if (article == null)
            {
                return Redirect("/");
            }
            List<Article> articles = _unitOfWork.Article.GetAll(
                orderBy: x => x.OrderByDescending(y => y.DateCreate),
                filter: a => a.ColumnistItem.ColumnistId == article.ColumnistItem.ColumnistId)
                .Select(a => a.LiteArticle())
                .Take(5)
                .ToList();
            article.View++;
            _unitOfWork.Article.Update(article);
            _unitOfWork.Save();
            ArticleDetailVM detailVM = new ArticleDetailVM(article, articles, article.ColumnistItem.ColumnistId, article.ColumnistItemId);
            return View(detailVM);
        }
    }
}
