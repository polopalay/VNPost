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
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            List<Article> articles = new List<Article>();
            foreach (Columnist c in _unitOfWork.Columnist.GetAll())
            {

                articles.AddRange(_unitOfWork.Article.GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate)).Where(a => a.ColumnistItem.ColumnistId == c.Id).Take(4));
            }
            ListArticleVM articleVM = new ListArticleVM(columnist, columnistItems, articles);
            return View(articleVM);
        }

        public IActionResult ListColumnist([FromQuery] int columnistId, [FromQuery] int columnistItemId, [FromQuery] int index)
        {
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            List<Article> articles;
            if (index == 0)
            {
                index = 1;
            }
            if (columnistId != 0)
            {
                articles = _unitOfWork.Article.GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate)).Where(a => a.ColumnistItem.ColumnistId == columnistId).ToList();
            }
            else if (columnistItemId != 0)
            {
                articles = _unitOfWork.Article.GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate)).Where(a => a.ColumnistItemId == columnistItemId).ToList();
            }
            else
            {
                articles = new List<Article>();
            }
            int numberPostInPage = 10;
            Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
            ListSearchArticleVM articleVM = new ListSearchArticleVM(pagination.ListT)
            {
                ColumnistId = columnistId,
                ColumnistItemId = columnistItemId,
                Begin = pagination.Begin,
                End = pagination.End,
                Index = index
            };
            return View(articleVM);
        }

        public IActionResult ArticleDetail(int id)
        {
            List<Columnist> columnists = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            Article article = _unitOfWork.Article.Get(id);
            article.View++;
            _unitOfWork.Article.Update(article);
            _unitOfWork.Save();
            ArticleDetailVM detailVM = new ArticleDetailVM(article, article.ColumnistItem.ColumnistId, article.ColumnistItemId);
            return View(detailVM);
        }
    }
}
