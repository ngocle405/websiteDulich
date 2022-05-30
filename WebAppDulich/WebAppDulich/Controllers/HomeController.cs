using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly ICategoryService _categoryService;
        private readonly IPlaceService _placeService;


        public HomeController(ILogger<HomeController> logger, TravelContext travelContext,ITourService tourService, ICategoryService categoryService,IPlaceService placeService)
        {
            _logger = logger;
            _tourService = tourService;
            _travelContext = travelContext;
            _categoryService = categoryService;
            _placeService = placeService;
           
        }

        public IActionResult SearchTour(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                var queryString = _travelContext.Tours.Select(p => new Tour()
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
                    Time = p.Time,
                    AreaName = p.AreaName
                }). Where(x => x.Name.Contains(keyword)).ToList();
                ViewBag.ListTour = queryString;
                ViewBag.keyword = keyword;
            }
            return View();
        }
        public SelectList loadCategory()
        {
            IEnumerable<Category> categories = _categoryService.GetAll();
            //  categories.Insert(0, new Category { Id = -1, Name = "-- Chọn danh mục --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");
            IEnumerable<Place> place = _placeService.GetAll();
            SelectList placeList = new SelectList(place, "Id", "PlaceName");
            ViewBag.categoryList = categoryList;
            ViewBag.placeList = placeList;
            return categoryList;
        }
        public IActionResult SearchTourForCategory(long? categoryId)
        {
            loadCategory();
            if (categoryId != null)
            {
                var queryString = _travelContext.Tours.Where(x => x.CategoryId == categoryId).ToList();
                ViewBag.ListTour = queryString;
            }
           
            return View();
        }
        public IActionResult SearchTourForPlace(long? placeId)
        {
            loadCategory();
            if (placeId != null)
            {
                var queryString = _travelContext.Tours.Where(x => x.PlaceId == placeId).ToList();
                ViewBag.ListTour = queryString;
            }

            return View();
        }

        public IActionResult Index()
        {
            loadCategory();
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
            order.PaymentStatus = 0;//0 là đang chờ  liên hệ 1 khách hàng hủy,2 hoạt động,
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

        public IActionResult TourBookingGuide()//hd dang ki tour
        {
            return View();
        }
        public IActionResult DepartureSchedule()//lịch khởi hành
        {
            ViewBag.ListProduct = _tourService.ShowTours();
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult News()//tin tức
        {
            ViewBag.lst = _travelContext.News;
            return View();
        }
        public IActionResult NewDescription(long id)//tin tức
        {
            var res=_travelContext.News.SingleOrDefault(x=>x.Id==id);
            return View(res);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
