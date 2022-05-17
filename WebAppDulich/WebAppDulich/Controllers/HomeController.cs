using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Data;
using WebAppDulich.Models;
using WebAppDulich.Services;

namespace WebAppDulich.Controllers
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
        public IActionResult OrderTour(long id)
        {
         
            var tour = _travelContext.Tours.SingleOrDefault(x => x.Id == id);
            ViewBag.tour = tour;
            return View();
        }
        public IActionResult Order(Order order)
        {
            order.CreatedDate = DateTime.Now;
             var result=_travelContext.Orders.Add(order);
            _travelContext.SaveChanges();
            if (result != null)
            {
                TempData["success"] = "Đặt Tour thành công,chúng tôi sẽ liên hệ lại bạn trong thời gian sớm nhất.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Đặt Tour thất bại";
            return View(order);
        }
        public IActionResult TourDescription(long id)
        {
            var relatedProduct=  _travelContext.Tours.Select(p => new Tour()
            {
                Id = p.Id,
                Name = p.Name,
                Logo = p.Logo,
                CategoryName = p.Category.Name,
                Description = p.Description,
                Price = p.Price,

                PriceDiscount = p.PriceDiscount,
                IsNew = p.IsNew,
                Url = p.Url,
                DisplayOrder = p.DisplayOrder,
                Status = p.Status,
                CreateDate = p.CreateDate,
                Code = p.Code,
                PlaceName = p.Place.PlaceName,
                Destination = p.Destination,
                DeparturePoint = p.DeparturePoint,
                Start = p.Start,
                Vehicle = p.Vehicle,
                Time = p.Time
                ,
                AreaName = p.AreaName
            }).SingleOrDefault(x => x.Id == id);
          
           // ViewBag.ListRelatedProduct = relatedProduct;
            return View(relatedProduct);
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
