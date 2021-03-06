﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VNPost.DataAccess.Repository.IRepository;
using VNPost.Models.Entity;
using VNPost.Models.ViewModels;

namespace VNPost.Controllers
{
    [Area("Main")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        public HomeController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            List<Banner> banners = _unitOfWork.Banner.GetAll().ToList();
            List<Category> categories = _unitOfWork.Category.GetAll().ToList();
            List<Service> posts = _unitOfWork.Service.GetAll().ToList();
            List<Article> articles = _unitOfWork.Article
                .GetAll(orderBy: x => x.OrderByDescending(y => y.DateCreate))
                .Take(5).ToList();
            HomeVM homeVM = new HomeVM(banners, categories, posts, articles);
            return View(homeVM);
        }
    }
}
