using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnistItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ColumnistItemsController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult GetColumnistItem()
        {
            var data = _unitOfWork.ColumnistItem.GetAll().ToList();
            return Ok(data);

        }

        [HttpGet("{id}")]
        public IActionResult GetColumnistItemByUser(string id)
        {
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.ColumnistItem.GetAll();
            string roleId = "";
            if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == id).Count() > 0)
            {
                roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == id).ToList()[0].RoleId;
            }
            List<ColumnistItem> columnistItems = new List<ColumnistItem>();
            foreach (RolePermission rolePermission in _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == roleId))
            {
                columnistItems.Add(rolePermission.ColumnistItem);
            }
            return Ok(columnistItems);

        }
    }
}