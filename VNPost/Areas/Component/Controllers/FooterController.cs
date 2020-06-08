using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNPost.Areas.Component.Controllers
{
    public class FooterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}