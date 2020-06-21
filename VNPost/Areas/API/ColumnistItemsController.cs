using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;

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
    }
}