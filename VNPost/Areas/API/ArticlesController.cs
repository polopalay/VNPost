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
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.IdentityUser.GetAll();
            List<Article> articles = new();

            if (_identityRole != null)
            {
                List<RolePermission> rolePermissions = _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == _identityRole.Id).ToList();
                List<int> columnistRp = new List<int>();
                foreach (RolePermission rolePermission in rolePermissions)
                {
                    columnistRp.Add(rolePermission.ColumnistId);
                }
                articles = _unitOfWork.Article.GetAll(filter: a => columnistRp.Contains(a.ColumnistId) && a.Accepted).ToList();
            }
            return Ok(new { data = articles });
        }

        [HttpGet("{id}")]
        public IActionResult GetArticle(int id)
        {
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.IdentityUser.GetAll();
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
            if (GetRolePermissionCanUpdate().Where(rp => rp.ColumnistId == comlumnistItemId).Count() == 0)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            article.Id = _unitOfWork.Article.Get(id).Id;
            article.DateCreate = _unitOfWork.Article.Get(id).DateCreate;
            article.IdentityUserId = _unitOfWork.Article.Get(id).IdentityUserId;
            article.View = _unitOfWork.Article.Get(id).View;
            article.ColumnistId = comlumnistItemId;
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
            if (GetRolePermissionCanCreate().Where(rp => rp.ColumnistId == comlumnistItemId).Count() == 0)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            string userId = _identityUser.Id;
            article.IdentityUserId = userId;
            article.ColumnistId = comlumnistItemId;
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
            if (GetRolePermissionCanDelete().Where(rp => rp.ColumnistId == article.ColumnistId).Count() == 0)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            _unitOfWork.Article.Remove(article);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Delete Successful" });

        }
    }
}