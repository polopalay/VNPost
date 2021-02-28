using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.Areas.Admin.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly SignInManager<IdentityUser> _signInManager;
        protected IdentityUser _identityUser = null;
        protected IdentityRole _identityRole = null;
        protected List<RolePermission> _rolePermissions = null;

        public BaseController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            GetIdentityUser();
            GetIdentityRole();
            GetRolePermission();
            base.OnActionExecuting(context);
        }

        protected void GetIdentityUser()
        {
            if (User != null)
            {
                if (_signInManager.IsSignedIn(User))
                {
                    _identityUser = _unitOfWork.IdentityUser.GetAll(filter: i => i.UserName == User.Identity.Name).ToList()[0];
                }
            }
        }

        protected void GetIdentityRole()
        {
            if (_identityUser != null)
            {
                if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id).ToList().Count() > 0)
                {
                    string roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id).ToList()[0].RoleId;
                    _identityRole = _unitOfWork.IdentityRole.Get(roleId);
                }
            }
        }
        protected void GetRolePermission()
        {
            if (_identityRole != null)
            {
                _rolePermissions = _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == _identityRole.Id).ToList();
            }
        }

        protected RolePermission GetDetailRolePermission(int columnistItemId)
        {
            if (_rolePermissions.Where(rp => rp.ColumnistId == columnistItemId).ToList().Count() > 0)
            {
                return _rolePermissions.Where(rp => rp.ColumnistId == columnistItemId).ToList()[0];
            }
            else
            {
                return null;
            }
        }

        protected List<RolePermission> GetRolePermissionCanCreate()
        {
            return _rolePermissions.Where(rp => rp.Create == true).ToList();
        }

        protected List<RolePermission> GetRolePermissionCanUpdate()
        {
            return _rolePermissions.Where(rp => rp.Update == true).ToList();
        }
        protected List<RolePermission> GetRolePermissionCanDelete()
        {
            return _rolePermissions.Where(rp => rp.Delete == true).ToList();
        }
        protected bool IsAdmin()
        {
            if (_identityRole == null)
            {
                return false;
            }
            if (_identityRole.Id == "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
            {
                return true;
            }
            return false;
        }
    }
}
