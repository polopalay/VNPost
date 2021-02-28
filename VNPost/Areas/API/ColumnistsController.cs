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
    public class ColumnistsController : BaseApiController
    {
        public ColumnistsController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
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
            string roleId = "";
            if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == id).Count() > 0)
            {
                roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == id).ToList()[0].RoleId;
            }
            List<Columnist> columnistItems = new List<Columnist>();
            foreach (RolePermission rolePermission in _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == roleId))
            {
                columnistItems.Add(rolePermission.Columnist);
                if (columnistItems.Where(cl => cl.Id == rolePermission.Columnist.FatherId).Count() == 0)
                {
                    columnistItems.Add(_unitOfWork.Columnist.Get(rolePermission.Columnist.FatherId));
                }
            }
            return Ok(columnistItems);

        }
        [HttpGet("current")]
        public IActionResult GetColumnisCurrentUser()
        {
            _unitOfWork.Columnist.GetAll();
            string roleId = "";
            if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id.ToString()).Count() > 0)
            {
                roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id.ToString()).ToList()[0].RoleId;
            }
            List<Columnist> columnistItems = new List<Columnist>();
            foreach (RolePermission rolePermission in _unitOfWork.RolePermission.GetAll(filter: rp => rp.RoleId == roleId))
            {
                columnistItems.Add(rolePermission.Columnist);
            }
            return Ok(columnistItems);

        }
    }
}