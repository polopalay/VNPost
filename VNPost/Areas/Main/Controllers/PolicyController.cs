using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNPost.Areas.Main.Controllers
{
    [Area("Main")]
    public class PolicyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
