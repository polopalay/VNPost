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
        public PermisionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] bool getPagination, [FromQuery] int index, [FromQuery] int numberPostInPage)
        {
            if (index == 0)
            {
                index = 1;
            }
            if (numberPostInPage == 0)
            {
                numberPostInPage = 10;
            }
            List<IdentityRole> role = _unitOfWork.IdentityRole.GetAll().Where(r=>r.Id!= "13d23c51-re38-4831-wqa2-2e3f21c23ewd").ToList();
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
        public IActionResult Get(int id)
        {
            return Ok(JsonConvert.SerializeObject(new { data = "" }));
        }

        [HttpPost]
        public IActionResult Post([FromQuery] string name, [FromBody] List<RolePermission> data)
        {
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
        public IActionResult Put(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(string id)
        {
            var objFromDb = _unitOfWork.IdentityRole.Get(id);
            if (objFromDb == null)
            {
                return Ok(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.RolePermission.RemoveRange(_unitOfWork.RolePermission.GetAll().Where(x=>x.RoleId==id));
            _unitOfWork.IdentityUserRole.RemoveRange(_unitOfWork.IdentityUserRole.GetAll().Where(x => x.RoleId == id));
            _unitOfWork.IdentityRole.Remove(objFromDb);
            _unitOfWork.Save();
            return Ok(new { success = true, message = "Delete Successful" });

        }
    }
}
