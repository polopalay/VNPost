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
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        public UserController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] bool getId, [FromQuery] bool getType)
        {

            if (getId)
            {
                if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                {
                    string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;
                    return Ok(userId);
                }
                else
                {
                    return Ok(null);
                }
            }
            else if (getType)
            {
                if (_signInManager.IsSignedIn(User))
                {
                    if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                    {
                        string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                        if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId).Count() == 0)
                        {
                            return Ok(null);
                        }
                        else
                        {
                            string roleId = _unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId).ToList()[0].RoleId;
                            return Ok(_unitOfWork.IdentityRole.Get(roleId).Name);
                        }
                    }
                    else
                    {
                        return Ok(null);
                    }
                }
                else
                {
                    return Ok(null);
                }
            }
            else
            {
                if (_signInManager.IsSignedIn(User))
                {
                    if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
                    {
                        string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;

                        if (_unitOfWork.IdentityUserRole.GetAll(ur => ur.UserId == userId && ur.RoleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd").Count() == 0)
                        {
                            return Ok(false);
                        }
                    }
                    else
                    {
                        return Ok(false);
                    }
                }
                else
                {
                    return Ok(false);
                }
                return Ok(true);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] string data)
        {
            if (_unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList().Count > 0)
            {
                string userId = _unitOfWork.IdentityUser.GetAll(filter: x => x.UserName == User.Identity.Name).ToList()[0].Id;
                string roleId = null;
                if (_unitOfWork.IdentityUserRole.GetAll(filter:ur=>ur.UserId==userId).Count()>0)
                {
                    roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == userId).ToList()[0].RoleId;
                }
                if (roleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
                {
                   return Ok(new { success = false, message = "Can't register admin" });
                }
                else
                {
                    _unitOfWork.IdentityUserRole.RemoveRange(_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == userId));
                    _unitOfWork.IdentityUserRole.Add(new IdentityUserRole<string> { RoleId = data, UserId = userId });
                    _unitOfWork.Save();
                    return Ok(new { success = true, message = "Register successfull" });
                }
            }
            else
            {
                return Ok(new { success = false, message = "Can't find user id" });
            }
        }
    }
}