using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.Tour;
using WebAppDulich.Data;
using WebAppDulich.Services;

namespace WebAppDulich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TourController : CheckLoginController
    {
        private ITourService _tourService;
        private ICategoryService _categoryService;
        private IPlaceService _placeService;
        public TourController(ITourService tourService, ICategoryService categoryService,IPlaceService placeService)
        {
            _placeService = placeService;
            _tourService = tourService;
            _categoryService = categoryService;
        }
        // GET: TourController
        public ActionResult Index()
        {
            var lst =  _tourService.GetAll();
            ViewBag.lst = lst;
            return View();
        }
        public SelectList loadCategory()
        {
            IEnumerable<Category> categories =  _categoryService.GetAll();
          //  categories.Insert(0, new Category { Id = -1, Name = "-- Chọn danh mục --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");
            IEnumerable<Place> place = _placeService.GetAll();
            SelectList placeList = new SelectList(place, "Id", "PlaceName");
            ViewBag.categoryList = categoryList;
            ViewBag.placeList = placeList;
            return categoryList;
        }
        // GET: TourController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TourController/Create
        public ActionResult Create()
        {
            loadCategory();
            return View();
        }

        // POST: TourController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public ActionResult Create(TourUpdateRequest request)
        {
            loadCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }


            if (request.CategoryId == -1)
            {
                ModelState.AddModelError("", "Bạn chưa chọn danh mục");
                TempData["warning"] = "Bạn chưa chọn danh mục";
                return View(request);
            }

            var result =  _tourService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");
            TempData["error"] = "Thêm mới sản phẩm thất bại";
            return View(request);
        }

        // GET: TourController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _tourService.Edit(id);
            //if (product == null)
            //{
            //    TempData["warning"] = "Tour không tồn tại";
            //    return RedirectToAction("Index");
            //}
            loadCategory();
            return View(product);
        }

        // POST: TourController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public ActionResult Edit(TourUpdateRequest request)
        {
             loadCategory();
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";

                return View(request);
            }

            if (request.CategoryId == -1)
            {
                ModelState.AddModelError("", "Bạn chưa chọn danh mục");
                TempData["warning"] = "Bạn chưa chọn danh mục";
                return View(request);
            }

            var result =  _tourService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật tour thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật tour thất bại");
                TempData["error"] = "Cập nhật tour thất bại";
                return View(request);
            }
        }

        // GET: TourController/Delete/5
        public ActionResult Delete(int id)
        {
            var model =  _tourService.Edit(id);
            if (model == null)
            {
                TempData["warning"] = "Tour không tồn tại";
                return RedirectToAction("Index");
            }
            var result =  _tourService.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa tour thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Sản phẩm có hóa đơn không thể xóa";
            return RedirectToAction("Index");
        }

       
    }
}
