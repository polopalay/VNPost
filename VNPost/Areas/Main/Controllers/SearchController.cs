using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Controllers
{
    [Area("Main")]
    public class SearchController : Controller
    {
        readonly IUnitOfWork _unitOfWork;
        public SearchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index([FromQuery] string id)
        {
            _unitOfWork.Status.GetAll();
            _unitOfWork.Province.GetAll();
            List<Parcel> parcels = _unitOfWork.Parcel.GetAll(filter: p => p.Code == id).ToList();
            if (parcels.Count == 0)
            {
                return View(new ParcelViewModel() { Id = 0 });
            }
            Parcel parcel = parcels[0];
            List<Location> locations = _unitOfWork.Location.GetAll(filter: l => l.ParcelId == parcel.Id, orderBy: ls => ls.OrderByDescending(l => l.Id)).ToList();
            Location location = locations.Count == 0 ? null : new Location() { Id = locations[0].Id, Description = locations[0].Description, District = _unitOfWork.District.Get(locations[0].DistricId) };
            ParcelViewModel parcelView = new ParcelViewModel()
            {
                Id = parcel.Id,
                Items = parcel.Items,
                Destination = parcel.Destination,
                CustomerInfo = parcel.CustomerInfo,
                OtherInfo = parcel.OtherInfo,
                PointAway = parcel.PointAway,
                Status = parcel.Status,
                Location = location
            };
            return View(parcelView);
        }
    }
}
