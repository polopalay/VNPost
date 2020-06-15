using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

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
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            List<Article> articles = new List<Article>();
            foreach (Columnist c in _unitOfWork.Columnist.GetAll())
            {

                articles.AddRange(_unitOfWork.Article.GetAll().Where(a => a.ColumnistItem.ColumnistId == c.Id).Take(4));
            }
            ListArticleVM articleVM = new ListArticleVM(columnist, columnistItems, articles);
            return View(articleVM);
        }

        public IActionResult ListColumnist([FromQuery] int columnistId, [FromQuery] int columnistItemId)
        {
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            List<Article> articles;
            if (columnistId != 0)
            {
                articles = _unitOfWork.Article.GetAll().Where(a => a.ColumnistItem.ColumnistId == columnistId).ToList();
            }
            else if (columnistItemId != 0)
            {
                articles = _unitOfWork.Article.GetAll().Where(a => a.ColumnistItemId == columnistItemId).ToList();
            }
            else
            {
                articles = new List<Article>();
            }
            ListSearchArticleVM articleVM = new ListSearchArticleVM(articles)
            {
                ColumnistId = columnistId,
                ColumnistItemId = columnistItemId
            };
            return View(articleVM);
        }
    }
}
