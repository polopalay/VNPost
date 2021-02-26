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
    public class LocationController : BaseApiController
    {
        public LocationController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        [HttpGet("province")]
        public IActionResult GetProvince()
        {
            return Ok(new { data = _unitOfWork.Province.GetAll() });
        }

        [HttpPut("province")]
        public IActionResult AddProvince([FromBody] Province province)
        {
            if (string.IsNullOrEmpty(province.Name))
            {
                return Ok("Tên không được để trống");
            }
            if (_unitOfWork.Province.GetAll(p => p.Name == province.Name).Count() > 0)
            {
                return Ok("Tên đã tồn tại");
            }
            Province newProvince = new Province() { Id = 0, Name = province.Name };
            _unitOfWork.Province.Add(newProvince);
            _unitOfWork.Save();
            return Ok("Thêm thành công");
        }

        [HttpPost("province")]
        public IActionResult UpdateProvince([FromBody] Province province)
        {
            Province provinceUpdate = _unitOfWork.Province.Get(province.Id);
            if (province == null)
            {
                return Ok("Không tìm thấy");
            }
            if (string.IsNullOrEmpty(province.Name))
            {
                return Ok("Tên không được để trống");
            }
            if (_unitOfWork.Province.GetAll(p => p.Name == province.Name).Count() > 0)
            {
                return Ok("Tên đã tồn tại");
            }
            provinceUpdate.Name = province.Name;
            _unitOfWork.Province.Update(provinceUpdate);
            _unitOfWork.Save();
            return Ok("Cập nhật thành công");
        }

        [HttpDelete("province/{id}")]
        public IActionResult DeleteProvince(int id)
        {
            Province province = _unitOfWork.Province.Get(id);
            if (province == null)
            {
                return Ok("Không tìm thấy");
            }
            _unitOfWork.Province.Remove(province);
            _unitOfWork.Save();
            return Ok("Xoá thành công");
        }

        [HttpGet("district/{id}")]
        public IActionResult GetDistrict(int id)
        {
            return Ok(new { data = _unitOfWork.District.GetAll(filter: d => d.ProvinceId == id) });
        }

        [HttpPut("district")]
        public IActionResult AddDistrict([FromBody] District province)
        {
            if (string.IsNullOrEmpty(province.Name))
            {
                return Ok("Tên không được để trống");
            }
            District newProvince = new District() { Id = 0, Name = province.Name, ProvinceId = province.ProvinceId };
            _unitOfWork.District.Add(newProvince);
            _unitOfWork.Save();
            return Ok("Thêm thành công");
        }

        [HttpPost("district")]
        public IActionResult UpdateDistrict([FromBody] District province)
        {
            District provinceUpdate = _unitOfWork.District.Get(province.Id);
            if (province == null)
            {
                return Ok("Không tìm thấy");
            }
            if (string.IsNullOrEmpty(province.Name))
            {
                return Ok("Tên không được để trống");
            }
            provinceUpdate.Name = province.Name;
            _unitOfWork.District.Update(provinceUpdate);
            _unitOfWork.Save();
            return Ok("Cập nhật thành công");
        }

        [HttpDelete("district/{id}")]
        public IActionResult DeleteDistrict(int id)
        {
            District province = _unitOfWork.District.Get(id);
            if (province == null)
            {
                return Ok("Không tìm thấy");
            }
            _unitOfWork.District.Remove(province);
            _unitOfWork.Save();
            return Ok("Xoá thành công");
        }
    }
}
