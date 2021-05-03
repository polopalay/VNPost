using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;

namespace VNPost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ParcelController : BaseController
    {
        [BindProperty]
        public Parcel Parcel { get; set; }
        [BindProperty]
        public Location Marker { get; set; }
        public ParcelController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager) : base(unitOfWork, signInManager)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int id)
        {
            Parcel = _unitOfWork.Parcel.Get(id);
            return View(Parcel ?? new Parcel());
        }

        [HttpPost]
        public IActionResult Upsert()
        {
            Marker = new Location
            {
                Description = "Demo"
            };
            if (ModelState.IsValid)
            {
                if (Parcel.Id == 0)
                {
                    _unitOfWork.Parcel.Add(Parcel);
                }
                else
                {
                    _unitOfWork.Parcel.Update(Parcel);
                }
                _unitOfWork.Save();
                return Redirect("/Admin/Parcel");
            }
            return View(Parcel);
        }

        public IActionResult Location(int id)
        {
            Marker = new Location() { ParcelId = id };
            return View(Marker);
        }

        [HttpPost]
        public IActionResult Location()
        {
            Marker.Id = 0;
            _unitOfWork.Location.Add(Marker);
            _unitOfWork.Save();
            return Redirect("/Admin/Parcel/Location/" + Marker.ParcelId);
        }

        public IActionResult Statistic()
        {
            return View();
        }
    }
}
