﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp_01.Data;
using WebApp_01.Models;
using WebApp_01.Services;

namespace WebApp_01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TravelContext _travelContext;
        private readonly ITourService _tourService;


        public HomeController(ILogger<HomeController> logger, TravelContext travelContext,ITourService tourService)
        {
            _logger = logger;
            _tourService = tourService;
            _travelContext = travelContext;
           
        }

        

        public IActionResult Index()
        {
            ViewBag.ListProduct = _tourService.ShowTours();
            //ViewBag.ListProduct =  _travelContext.Tours.Where(a => a.PriceDiscount != null && a.DisplayOrder != null && a.Status == 1).OrderBy(x => x.DisplayOrder).Take(12).ToList();
            ViewBag.ListPlace = _travelContext.Places.Where(x => x.Status == 1).ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
