using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.Areas.API
{
    [Route("api/[controller]")]
    public class ParcelController : BaseApiController
    {
        public ParcelController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            _unitOfWork.Status.GetAll();
            return Ok(new { data = _unitOfWork.Parcel.GetAll() });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDistrict(int id)
        {
            Parcel parcel = _unitOfWork.Parcel.Get(id);
            if (parcel == null)
            {
                return Ok("Không tìm thấy");
            }
            _unitOfWork.Parcel.Remove(parcel);
            _unitOfWork.Save();
            return Ok("Xoá thành công");
        }
    }
}
