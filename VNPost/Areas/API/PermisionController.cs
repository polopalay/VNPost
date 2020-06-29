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
    public class PermisionController : BaseApiController
    {
        public PermisionController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }
        [HttpGet]
        public IActionResult Get([FromQuery] bool getPagination = false, [FromQuery] bool dontPaging = false,
            [FromQuery] int index = 1, [FromQuery] int numberPostInPage = 10)
        {
            List<IdentityRole> role = _unitOfWork.IdentityRole.GetAll().ToList();
            if (dontPaging)
            {
                return Ok(role.Where(r => r.Id != "13d23c51-re38-4831-wqa2-2e3f21c23ewd"));
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
        public IActionResult Get(string id, [FromQuery] bool getName)
        {
            if (!CheckUser())
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.ColumnistItem.GetAll();
            _unitOfWork.IdentityRole.GetAll();
            if (getName)
            {
                if (_unitOfWork.IdentityRole.Get(id) != null)
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
            if (!CheckUser())
            {
                return Ok(new { success = false, message = "Don't have permision" });
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
            if (!CheckUser())
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            if (data == null || _unitOfWork.IdentityRole.Get(id) == null)
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
            if (!CheckUser())
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            var objFromDb = _unitOfWork.IdentityRole.Get(id);
            if (objFromDb == null)
            {
                return Ok(new { success = false, message = "Error while deleting" });
            }
            if (id == "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
            {
                return Ok(new { success = false, message = "Can't delete admin" });
            }
            try
            {
                _unitOfWork.RolePermission.RemoveRange(_unitOfWork.RolePermission.GetAll().Where(x => x.RoleId == id));
                _unitOfWork.IdentityUserRole.RemoveRange(_unitOfWork.IdentityUserRole.GetAll().Where(x => x.RoleId == id));
                _unitOfWork.IdentityRole.Remove(objFromDb);
                _unitOfWork.Save();
            }
            catch
            {
                return Ok(new { success = false, message = "Error while deleting" });
            }
            return Ok(new { success = true, message = "Delete Successful" });

        }

        private bool CheckUser()
        {
            if (_identityUser == null)
            {
                return false;
            }
            if (_identityRole == null)
            {
                return false;
            }
            if (_identityRole.Id != "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
            {
                return false;
            }
            return true;
        }
    }
}
