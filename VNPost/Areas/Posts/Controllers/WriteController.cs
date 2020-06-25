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
        private readonly SignInManager<IdentityUser> _signInManager;

        public WriteController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
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
                if(id==0)
                {
                    return View();
                }
                _unitOfWork.ColumnistItem.GetAll();
                Article objFromDb = _unitOfWork.Article.Get(id);
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;
                    if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == userId).Count() > 0)
                    {
                        string roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == userId).ToList()[0].RoleId;
                        if (_unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == roleId && rp.ColumnistItemId == objFromDb.ColumnistItemId).Count() > 0)
                        {
                            RolePermission rolePermission =
                                _unitOfWork.RolePermission.GetAll(
                                    filter: rp => rp.RoleId == roleId && rp.ColumnistItemId == objFromDb.ColumnistItemId
                                    ).ToList()[0];
                            if (!rolePermission.Delete)
                            {
                                return Forbid();
                            }
                        }
                        else
                        {
                            return Forbid();
                        }
                    }
                    else
                    {
                        return Forbid();
                    }
                }
                else
                {
                    return Forbid();
                }
                return View();
            }

        }
    }
}
