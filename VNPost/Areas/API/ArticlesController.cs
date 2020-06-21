using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Utility;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ArticlesController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult GetArticles([FromQuery] int index,
            [FromQuery] bool getTop5ByDate, [FromQuery] bool getTop1ByView,
            [FromQuery] bool getAll, [FromQuery] bool getPagination,
            [FromQuery] bool fillToDataTable, [FromQuery] bool getLatest,
            [FromQuery] int columnistId, [FromQuery] int columnistItemId,
            [FromQuery] int numberPostInPage)
        {
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll().ToList();
            List<ColumnistItem> columnistItems = _unitOfWork.ColumnistItem.GetAll().ToList();
            if (index == 0)
            {
                index = 1;
            }
            if (numberPostInPage == 0)
            {
                numberPostInPage = 10;
            }
            List<Article> articles = new List<Article>();

            if (getAll)
            {
                articles.AddRange(_unitOfWork.Article.GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate)).ToList());
                Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
                if (getPagination)
                {
                    return Ok(pagination.SortPagination());
                }
                else
                {
                    if (fillToDataTable)
                    {
                        return Ok(JsonConvert.SerializeObject(new { data = pagination.ListT }));
                    }
                    else
                    {
                        return Ok(pagination.ListT);
                    }
                }
            }
            else if (getLatest)
            {
                articles.AddRange(_unitOfWork.Article.GetAll(
                orderBy: x => x.OrderByDescending(y => y.DateCreate))
                .Select(a => a.LiteArticle())
                .Take(5)
                .ToList());
                if (fillToDataTable)
                {
                    return Ok(JsonConvert.SerializeObject(new { data = articles }));
                }
                else
                {
                    return Ok(articles);
                }
            }
            else if (getTop5ByDate)
            {
                foreach (Columnist c in _unitOfWork.Columnist.GetAll())
                {
                    articles.AddRange(_unitOfWork.Article.GetAll(
                        orderBy: x => x.OrderByDescending(y => y.DateCreate),
                        filter: a => a.ColumnistItem.ColumnistId == c.Id)
                        .Select(a => a.SoftArticle())
                        .Take(5));
                }
                if (fillToDataTable)
                {
                    return Ok(JsonConvert.SerializeObject(new { data = articles }));
                }
                else
                {
                    return Ok(articles);
                }
            }
            else if (getTop1ByView)
            {
                foreach (Columnist c in _unitOfWork.Columnist.GetAll())
                {
                    List<Article> listNew = _unitOfWork.Article.GetAll(
                        orderBy: x => x.OrderByDescending(y => y.View),
                        filter: a => a.ColumnistItem.ColumnistId == c.Id).ToList();
                    if (listNew.Count > 0)
                    {
                        articles.Add(listNew[0]);
                    }
                }

                if (fillToDataTable)
                {
                    return Ok(JsonConvert.SerializeObject(new { data = articles }));
                }
                else
                {
                    return Ok(articles);
                }
            }
            else if (columnistId != 0)
            {
                articles.AddRange(_unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.ColumnistItem.ColumnistId == columnistId)
                    .Select(a => a.SoftArticle())
                    .ToList());
                Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
                if (getPagination)
                {
                    return Ok(pagination.SortPagination());
                }
                else
                {
                    if (fillToDataTable)
                    {
                        return Ok(JsonConvert.SerializeObject(new { data = pagination.ListT }));
                    }
                    else
                    {
                        return Ok(pagination.ListT);
                    }
                }
            }
            else if (columnistItemId != 0)
            {
                articles.AddRange(_unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.ColumnistItemId == columnistItemId)
                    .Select(a => a.SoftArticle())
                    .ToList());
                Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
                if (getPagination)
                {
                    return Ok(pagination.SortPagination());
                }
                else
                {
                    if (fillToDataTable)
                    {
                        return Ok(JsonConvert.SerializeObject(new { data = pagination.ListT }));
                    }
                    else
                    {
                        return Ok(pagination.ListT);
                    }
                }
            }
            else
            {
                Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
                if (getPagination)
                {
                    return Ok(pagination.SortPagination());
                }
                else
                {
                    if (fillToDataTable)
                    {
                        return Ok(JsonConvert.SerializeObject(new { data = pagination.ListT }));
                    }
                    else
                    {
                        return Ok(pagination.ListT);
                    }
                }
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            var article = _unitOfWork.Article.Get(id);
            return Ok(article);
        }

        [HttpPut("{id}")]
        public IActionResult PutArticle(int id, [FromQuery] int comlumnistItemId, [FromBody] Article article)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Forbid();
            }
            if (article == null || comlumnistItemId == 0 || id == 0 || _unitOfWork.Article.Get(id) == null)
            {
                return Ok(new { success = false, message = "Error while updating" });
            }
            article.Id = _unitOfWork.Article.Get(id).Id;
            article.DateCreate = _unitOfWork.Article.Get(id).DateCreate;
            article.View = _unitOfWork.Article.Get(id).View;
            article.ColumnistItemId = comlumnistItemId;
            _unitOfWork.Article.Update(article);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Update Successful" });
        }

        [HttpPost]
        public IActionResult PostArticle([FromQuery] int comlumnistItemId, [FromBody] Article article)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Forbid();
            }
            if (article == null || comlumnistItemId == 0)
            {
                return Ok(new { success = false, message = "Error while inserting" });
            }

            article.ColumnistItemId = comlumnistItemId;
            article.DateCreate = DateTime.Now;
            article.View = 0;
            _unitOfWork.Article.Add(article);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Insert Successful" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var objFromDb = _unitOfWork.Article.Get(id);
            if (objFromDb == null)
            {
                return Ok(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Article.Remove(objFromDb);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Delete Successful" });

        }
    }
}