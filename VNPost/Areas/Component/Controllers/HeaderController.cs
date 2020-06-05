using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Data;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.ClassModels;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Component.Controllers
{
    [Area("Component")]
    public class HeaderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HeaderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            Dictionary<string, string> listDescription = new Dictionary<string, string>();
            foreach(Description description in _unitOfWork.Description.GetAll())
            {
                listDescription.Add(description.Key, description.Value);
            }
            return View(listDescription);
        }
    }
}