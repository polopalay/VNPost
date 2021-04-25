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
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll(filter: cl => cl.FatherId == 0).ToList();
            List<Columnist> columnistItems = _unitOfWork.Columnist.GetAll(filter: cl => cl.FatherId != 0).ToList();
            List<Article> articles = new();
            List<Article> mostNewArticles = new();
            foreach (Columnist c in _unitOfWork.Columnist.GetAll())
            {
                articles.AddRange(_unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.Columnist.FatherId == c.Id && a.Accepted)
                    .Take(5));
                List<Article> listNew = _unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.View),
                    filter: a => a.Columnist.FatherId == c.Id && a.Accepted).ToList();
                if (listNew.Count > 0)
                {
                    mostNewArticles.Add(listNew[0]);
                }
            }
            ListArticleVM articleVM = new(columnist, columnistItems, articles)
            {
                MostNewArticles = mostNewArticles
            };
            return View(articleVM);
        }

        public IActionResult ListColumnist([FromQuery] int columnistId, [FromQuery] int columnistItemId, [FromQuery] int index)
        {
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll(filter: cl => cl.FatherId == 0).ToList();
            List<Columnist> columnistItems = _unitOfWork.Columnist.GetAll(filter: cl => cl.FatherId != 0).ToList();
            List<Article> articles;
            if (index == 0)
            {
                index = 1;
            }
            if (columnistId != 0)
            {
                articles = _unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.Columnist.FatherId == columnistId && a.Accepted)
                    .ToList();
            }
            else if (columnistItemId != 0)
            {
                articles = _unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.ColumnistId == columnistItemId && a.Accepted)
                    .ToList();
            }
            else
            {
                articles = new List<Article>();
            }
            int numberPostInPage = 6;
            Pagination<Article> pagination = new(articles, index, numberPostInPage);
            ListSearchArticleVM articleVM = new(pagination.ListT)
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
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll(filter: cl => cl.FatherId == 0).ToList();
            List<Columnist> columnistItems = _unitOfWork.Columnist.GetAll(filter: cl => cl.FatherId != 0).ToList();
            Article article = _unitOfWork.Article.Get(id);
            if (article == null)
            {
                return Redirect("/");
            }
            List<Article> articles = _unitOfWork.Article.GetAll(
                orderBy: x => x.OrderByDescending(y => y.DateCreate),
                filter: a => a.Columnist.FatherId == article.Columnist.FatherId)
                .Take(5)
                .ToList();
            article.View++;
            _unitOfWork.Article.Update(article);
            _unitOfWork.Save();
            ArticleDetailVM detailVM = new ArticleDetailVM(article, articles, article.Columnist.FatherId, article.ColumnistId);
            return View(detailVM);
        }
    }
}
