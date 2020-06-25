using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Utility;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnistsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ColumnistsController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult GetColumnists()
        {
            var data = _unitOfWork.Columnist.GetAll().ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetColumnisByUser(string id)
        {
            _unitOfWork.Columnist.GetAll();
            _unitOfWork.ColumnistItem.GetAll();
            string roleId = "";
            if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == id).Count() > 0)
            {
                roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == id).ToList()[0].RoleId;
            }
            List<Columnist> columnistItems = new List<Columnist>();
            foreach (RolePermission rolePermission in _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == roleId))
            {
                if(columnistItems.Where(c=>c.Id==rolePermission.ColumnistItem.ColumnistId).Count()==0)
                {
                    columnistItems.Add(rolePermission.ColumnistItem.Columnist);
                }
            }
            return Ok(columnistItems);

        }
    }
}