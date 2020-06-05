using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Component.Controllers
{
    [Area("Component")]
    public class HeaderController : Controller
    {
        public IActionResult Index()
        {
            HeaderViewModel headerView = new HeaderViewModel();
            headerView.Name = "Hello";
            return View(headerView);
        }
    }
}