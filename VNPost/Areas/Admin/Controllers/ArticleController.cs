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

        public ArticleController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        public IActionResult Index()
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Upsert([FromQuery] int id)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return Redirect("/Identity/Account/Login");
            }
            else
            {
                if (_identityRole == null)
                {
                    return Forbid();
                }
                Article article = _unitOfWork.Article.Get(id);
                if (article == null)
                {
                    if (GetRolePermissionCanCreate().Count() > 0)
                    {
                        return View();
                    }
                    else
                    {
                        return Forbid();
                    }
                }
                else
                {
                    RolePermission rolePermission = GetDetailRolePermission(article.ColumnistItemId);
                    if (rolePermission == null)
                    {
                        return Forbid();
                    }
                    if (rolePermission.Update)
                    {
                        return View();
                    }
                    else
                    {
                        return Forbid();
                    }
                }

            }

        }
    }
}
