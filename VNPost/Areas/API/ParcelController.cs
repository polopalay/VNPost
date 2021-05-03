using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

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

        [HttpGet("statistic")]
        public IActionResult GetStatistics()
        {
            return Ok(new { data = _unitOfWork.Parcel.GetAll(filter: p => p.StatusId == 3, orderBy: ps => ps.OrderBy(p => p.DateEnd)).GroupBy(p => new { p.DateEnd.Value.Month, p.DateEnd.Value.Year }).Select(p => new ParcelVM() { Price = p.Sum(s => s.Price), Month = p.ToList()[0].DateEnd.Value.Month, Year = p.ToList()[0].DateEnd.Value.Year }) });
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
            if (statusId == 2)
            {
                parcelUpdate.DateStart = DateTime.Now;
            }
            else if (statusId == 3)
            {
                parcelUpdate.DateEnd = DateTime.Now;
                Price price = _unitOfWork.Price.Get(1);
                parcelUpdate.Price = (parcelUpdate.Long * parcelUpdate.Wide * parcelUpdate.Height * price.Size + parcelUpdate.Weight * price.Weight) * (1 + parcelUpdate.Distance / price.Distance);
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
