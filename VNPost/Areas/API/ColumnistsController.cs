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
    }
}