using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Areas.Components
{
    public class LeftViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public LeftViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke([FromQuery] int columnistId, [FromQuery] int columnistItemId)
        {
            List<Columnist> columnist = _unitOfWork.Columnist.GetAll().ToList();
            LeftVM articleVM = new LeftVM(columnist, columnistId, columnistItemId);
            return View(articleVM);
        }
    }
}
