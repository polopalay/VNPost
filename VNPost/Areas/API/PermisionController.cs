using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VNPost.DataAccess.Repository;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Utility;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        public PermisionController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] bool getPagination, [FromQuery] int index, [FromQuery] int numberPostInPage,[FromQuery] bool dontPaging)
        {

            if (index == 0)
            {
                index = 1;
            }
            if (numberPostInPage == 0)
            {
                numberPostInPage = 10;
            }
            List<IdentityRole> role = _unitOfWork.IdentityRole.GetAll().ToList();
            if(dontPaging)
            {
                return Ok(role.Where(r=>r.Id!= "13d23c51-re38-4831-wqa2-2e3f21c23ewd"));
            }
            Pagination<IdentityRole> pagination = new Pagination<IdentityRole>(role, index, numberPostInPage);
            if (getPagination)
            {
                return Ok(pagination.SortPagination());
            }
            else
            {
                return Ok(JsonConvert.SerializeObject(new { data = pagination.ListT }));
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id,[FromQuery] bool getName)
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                    if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
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
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.ColumnistItem.GetAll();
            _unitOfWork.IdentityRole.GetAll();
            if(getName)
            {
                if(_unitOfWork.IdentityRole.Get(id)!=null)
                {
                    string name = _unitOfWork.IdentityRole.Get(id).Name;
                    return Ok(name);
                }
            }
            return Ok(_unitOfWork.RolePermission.GetAll(filter: x => x.RoleId == id));
        }

        [HttpPost]
        public IActionResult Post([FromQuery] string name, [FromBody] List<RolePermission> data)
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                    if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
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
            if (name == null)
            {
                return Ok(new { success = false, message = "Error while inserting" });
            }
            IdentityRole role = new IdentityRole(name);
            try
            {
                _unitOfWork.IdentityRole.Add(role);
                foreach (RolePermission rolePermission in data)
                {
                    rolePermission.RoleId = role.Id;
                    _unitOfWork.RolePermission.Add(rolePermission);
                }
            }
            catch
            {
                return Ok(new { success = false, message = "Error while inserting" });
            }
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Insert Successful" });
        }

        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromQuery] string name, [FromBody] List<RolePermission> data)
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                    if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
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
            if (data == null || data.Count == 0 || _unitOfWork.IdentityRole.Get(id) == null)
            {
                return Ok(new { success = false, message = "Error while updating" });
            }
            try
            {
                _unitOfWork.RolePermission.RemoveRange(_unitOfWork.RolePermission.GetAll().Where(x => x.RoleId == id));
                foreach (RolePermission rolePermission in data)
                {
                    rolePermission.RoleId = id;
                    _unitOfWork.RolePermission.Add(rolePermission);
                }
                IdentityRole role = _unitOfWork.IdentityRole.Get(id);
                _unitOfWork.IdentityRole.Update(role, name);
            }
            catch
            {
                return Ok(new { success = false, message = "Error while updating" });
            }
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Update Successful" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(string id)
        {
            if (_signInManager.IsSignedIn(User))
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                    if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
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
            var objFromDb = _unitOfWork.IdentityRole.Get(id);
            if (objFromDb == null)
            {
                return Ok(new { success = false, message = "Error while deleting" });
            }
            if(id== "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
            {
                return Ok(new { success = false, message = "Can't delete admin" });
            }
            _unitOfWork.RolePermission.RemoveRange(_unitOfWork.RolePermission.GetAll().Where(x => x.RoleId == id));
            _unitOfWork.IdentityUserRole.RemoveRange(_unitOfWork.IdentityUserRole.GetAll().Where(x => x.RoleId == id));
            _unitOfWork.IdentityRole.Remove(objFromDb);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Delete Successful" });

        }
    }
}
