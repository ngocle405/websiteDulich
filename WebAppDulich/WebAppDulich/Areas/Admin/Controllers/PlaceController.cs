using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models;
using WebAppDulich.Services;

namespace WebAppDulich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlaceController : Controller
    {
        private IPlaceService _placeService;
        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }
        // GET: PlaceController
        public ActionResult Index()
        {
            var lst = _placeService.GetAll();
            ViewBag.lst = lst;
            return View();
        }

        // GET: PlaceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlaceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlaceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlaceRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result =  _placeService.Create(request);
            if (result != -1)
            {
                TempData["success"] = "Thêm mới địa điểm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm địa điểm thất bại");
            TempData["error"] = "Thêm mới địa điểm thất bại";
            return View(request);
        }

        // GET: PlaceController/Edit/5
        public ActionResult Edit(long id)
        {
            var place = _placeService.Edit(id);
            if (place == null)
            {
                TempData["warning"] = "Địa điểm không tồn tại";
                return RedirectToAction("Index");
            }

            return View(place);
        }

        // POST: PlaceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PlaceRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }


            var result =  _placeService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật địa điểm thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật địa điểm thất bại");
                TempData["error"] = "Cập nhật địa điểm thất bại";
                return View(request);
            }
        }

      
        // POST: PlaceController/Delete/5
        public IActionResult Delete(long id)
        {
            var model = _placeService.Edit(id);
            if (model == null)
            {
                TempData["warning"] = "Địa điểm không tồn tại";
                return RedirectToAction("Index");
            }

            var result = _placeService.Delete(id);
            if (result != 1)
            {
                TempData["warning"] = "địa điểm chứa Tour ko thể xóa";
                ModelState.AddModelError("", "địa điểm chứa Tour ko thể xóa");
                return RedirectToAction("Index");
            }
            TempData["success"] = "Xóa địa điểm thành công";
            return RedirectToAction("Index");
        }
    }
}
