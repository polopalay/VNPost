using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UserController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager) : base(unitOfWork, signInManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] bool getId, [FromQuery] bool getType, [FromQuery] bool getName,
            [FromQuery] bool getAll)
        {

            if (getAll)
            {
                List<UserRole> userRoles = new List<UserRole>();
                List<string> userHaveRole = new List<string>();
                foreach (IdentityUserRole<string> identityUserRole in _unitOfWork.IdentityUserRole.GetAll())
                {
                    UserRole userRole = new UserRole()
                    {
                        IdentityRole = new IdentityRole()
                        {
                            Id = _unitOfWork.IdentityRole.Get(identityUserRole.RoleId).Id,
                            Name = _unitOfWork.IdentityRole.Get(identityUserRole.RoleId).Name,
                        },
                        IdentityUser = new IdentityUser()
                        {
                            Id = _unitOfWork.IdentityUser.Get(identityUserRole.UserId).Id,
                            UserName = _unitOfWork.IdentityUser.Get(identityUserRole.UserId).UserName,
                        },
                    };
                    userHaveRole.Add(userRole.IdentityUser.Id);
                    userRoles.Add(userRole);
                }
                foreach (IdentityUser user in _unitOfWork.IdentityUser.GetAll(filter: u => (!userHaveRole.Contains(u.Id))))
                {
                    UserRole userRole = new UserRole()
                    {
                        IdentityUser = user,
                    };
                    userRoles.Add(userRole);

                }
                return Ok(JsonConvert.SerializeObject(new { data = userRoles }));
            }
            else if (getId)
            {
                return Ok(_identityUser == null ? null : _identityUser.Id);
            }
            else if (getType)
            {
                return Ok(_identityRole == null ? null : _identityRole.Name);
            }
            else if (getName)
            {
                return Ok(_identityUser == null ? null : _identityUser.UserName);
            }
            else
            {
                return Ok(_identityRole == null ? false : _identityRole.Id == "13d23c51-re38-4831-wqa2-2e3f21c23ewd");
            }
        }

        [HttpPost("{userId}")]
        public IActionResult Post(string userId, [FromBody] string roleId)
        {
            if (_identityRole == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            else
            {
                if (_identityRole.Id != "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
                {
                    return Ok(new { success = false, message = "Don't have permision" });
                }
            }
            if (roleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
            {
                return Ok(new { success = false, message = "Can't set type admin" });
            }
            else
            {
                _unitOfWork.IdentityUserRole.RemoveRange(_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == userId));
                if (roleId != "")
                {
                    _unitOfWork.IdentityUserRole.Add(new IdentityUserRole<string> { RoleId = roleId, UserId = userId });
                }
                _unitOfWork.Save();
                return Ok(new { success = true, message = "Set type successfull" });
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] IdentityUser identityUser, [FromQuery] string password)
        {
            if (_identityRole == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            else
            {
                if (_identityRole.Id != "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
                {
                    return Ok(new { success = false, message = "Don't have permision" });
                }
            }
            identityUser.Email = identityUser.UserName;
            identityUser.EmailConfirmed = true;
            var result = _userManager.CreateAsync(identityUser, password);
            _unitOfWork.Save();
            if (result.IsCompletedSuccessfully)
            {
                return Ok(new { success = true, message = "Successfull" });
            }
            else
            {
                return Ok(new { success = false, message = "Fail" });
            }

        }

        [HttpDelete("{userId}")]
        public IActionResult Delete(string userId)
        {
            if (_identityRole == null)
            {
                return Ok(new { success = false, message = "Don't have permision" });
            }
            else
            {
                if (_identityRole.Id != "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
                {
                    return Ok(new { success = false, message = "Don't have permision" });
                }
            }
            try
            {
                string roleId = null;
                if (_unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == userId).ToList().Count() > 0)
                {
                    roleId = _unitOfWork.IdentityUserRole.GetAll(filter: ur => ur.UserId == _identityUser.Id).ToList()[0].RoleId;
                    if (roleId == "13d23c51-re38-4831-wqa2-2e3f21c23ewd")
                    {
                        return Ok(new { success = false, message = "Can't delete admin" });
                    }
                }
                if (roleId != null)
                {
                    if (_identityUser != null)
                    {
                    }
                    _unitOfWork.IdentityUserRole.Remove(userId, roleId);
                }
                _unitOfWork.IdentityUser.Remove(userId);
                _unitOfWork.Save();
                return Ok(new { success = true, message = "Remove successfull" });
            }
            catch
            {
                _unitOfWork.Save();
                return Ok(new { success = false, message = "Remove fail" });

            }
        }
    }
}