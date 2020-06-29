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
    public class ArticlesController : BaseApiController
    {
        public ArticlesController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.ColumnistItem.GetAll();
            _unitOfWork.IdentityUser.GetAll();
        }

        [HttpGet]
        public IActionResult GetArticles([FromQuery] int index = 1, [FromQuery] int numberPostInPage = 10,
            [FromQuery] int columnistId = 0, [FromQuery] int columnistItemId = 0,
            [FromQuery] bool getTop5ByDate = false, [FromQuery] bool getTop1ByView = false,
            [FromQuery] bool getAll = false, [FromQuery] bool getPagination = false,
            [FromQuery] bool fillToDataTable = false, [FromQuery] bool getLatest = false,
            [FromQuery] bool getByUSer = false)
        {
            List<Article> articles = new List<Article>();
            if (getAll)
            {
                articles = _unitOfWork.Article.GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate)).ToList();
            }
            else if (getByUSer)
            {
                if (_identityRole != null)
                {
                    List<RolePermission> rolePermissions = _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == _identityRole.Id).ToList();
                    List<int> columnistRp = new List<int>();
                    foreach (RolePermission rolePermission in rolePermissions)
                    {
                        columnistRp.Add(rolePermission.ColumnistItemId);
                    }
                    articles = _unitOfWork.Article.GetAll(filter: a => columnistRp.Contains(a.ColumnistItemId)).ToList();
                }
            }
            else if (getLatest)
            {
                articles = _unitOfWork.Article.GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate)).Select(a => a.LiteArticle()).Take(5).ToList();
            }
            else if (getTop5ByDate)
            {
                articles = GetArticleByDateForEachType(5);
            }
            else if (getTop1ByView)
            {
                articles = GetArticleByViewForEachType(1);
            }
            else if (columnistId != 0)
            {
                articles = _unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.ColumnistItem.ColumnistId == columnistId)
                    .Select(a => a.SoftArticle()).ToList();
            }
            else if (columnistItemId != 0)
            {
                articles = _unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.ColumnistItemId == columnistItemId)
                    .Select(a => a.SoftArticle()).ToList();
            }
            if (getAll || columnistId != 0 || columnistItemId != 0)
            {
                Pagination<Article> pagination = new Pagination<Article>(articles, index, numberPostInPage);
                if (getPagination)
                {
                    return Ok(pagination.SortPagination());
                }
                else
                {
                    articles = pagination.ListT;
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

        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            var article = _unitOfWork.Article.Get(id);
            return Ok(article);
        }

        [HttpPut("{id}")]
        public IActionResult PutArticle(int id, [FromQuery] int comlumnistItemId, [FromBody] Article article)
        {
            if (_identityUser == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (_rolePermissions == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (GetRolePermissionCanUpdate().Where(rp => rp.ColumnistItemId == comlumnistItemId).Count() == 0)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            article.Id = _unitOfWork.Article.Get(id).Id;
            article.DateCreate = _unitOfWork.Article.Get(id).DateCreate;
            article.IdentityUserId = _unitOfWork.Article.Get(id).IdentityUserId;
            article.View = _unitOfWork.Article.Get(id).View;
            article.ColumnistItemId = comlumnistItemId;
            _unitOfWork.Article.Update(article);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Update Successful" });
        }

        [HttpPost]
        public IActionResult PostArticle([FromQuery] int comlumnistItemId, [FromBody] Article article)
        {
            if (_identityUser == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (_rolePermissions == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (GetRolePermissionCanCreate().Where(rp => rp.ColumnistItemId == comlumnistItemId).Count() == 0)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            string userId = _identityUser.Id;
            article.IdentityUserId = userId;
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
            Article article = _unitOfWork.Article.Get(id);
            if (article == null)
            {
                return Ok(new { success = false, message = "Not found" });
            }
            if (_identityUser == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (_rolePermissions == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (GetRolePermissionCanDelete().Where(rp => rp.ColumnistItemId == article.ColumnistItemId).Count() == 0)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            _unitOfWork.Article.Remove(article);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Delete Successful" });

        }

        private List<Article> GetArticleByDateForEachType(int number)
        {
            List<Article> articles = new List<Article>();
            foreach (Columnist c in _unitOfWork.Columnist.GetAll())
            {
                articles.AddRange(_unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.DateCreate),
                    filter: a => a.ColumnistItem.ColumnistId == c.Id)
                    .Select(a => a.SoftArticle())
                    .Take(number));
            }
            return articles;
        }

        private List<Article> GetArticleByViewForEachType(int number)
        {
            List<Article> articles = new List<Article>();
            foreach (Columnist c in _unitOfWork.Columnist.GetAll())
            {
                List<Article> listNew = _unitOfWork.Article.GetAll(
                    orderBy: x => x.OrderByDescending(y => y.View),
                    filter: a => a.ColumnistItem.ColumnistId == c.Id).ToList();
                if (listNew.Count >= number)
                {
                    articles.AddRange(listNew.Take(number));
                }
            }
            return articles;
        }
    }
}