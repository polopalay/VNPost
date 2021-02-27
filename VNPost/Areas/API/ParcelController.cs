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

        [HttpPost]
        public IActionResult Get([FromQuery] int id, [FromQuery] int statusId)
        {
            Parcel parcelUpdate = _unitOfWork.Parcel.Get(id);
            if (parcelUpdate == null)
            {
                return Ok("Không tìm thấy bưu kiện");
            }
            Status status = _unitOfWork.Status.Get(statusId);
            if (status == null)
            {
                return Ok("Không tìm thấy trạng thái");
            }
            parcelUpdate.StatusId = statusId;
            _unitOfWork.Parcel.Update(parcelUpdate);
            _unitOfWork.Save();
            return Ok("Cập nhật thành công");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDistrict(int id)
        {
            Parcel parcel = _unitOfWork.Parcel.Get(id);
            foreach (Location location in _unitOfWork.Location.GetAll(filter: l => l.ParcelId == id))
            {
                _unitOfWork.Location.Remove(location);
            }
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
