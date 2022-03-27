using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_01.Areas.Admin.Models.Slide;
using WebApp_01.Services;

namespace WebApp_01.Areas.Admin.Controllers
{
   [Area("admin")]
    public class SlideController : Controller
    {
        private readonly ISlideService _slideService;

        public SlideController(ISlideService slideService)
        {
            _slideService = slideService;
        }
        // GET: SlideController
        public ActionResult Index()
        {

            var lstSlide =  _slideService.GetAll();
            ViewBag.lstSlide = lstSlide;
            return View();
        }

        // GET: SlideController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SlideController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SlideController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public ActionResult Create(SlideCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result =  _slideService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới slide thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm slide thất bại");
            TempData["error"] = "Thêm mới slide thất bại";
            return View(request);
        }

        // GET: SlideController/Edit/5
        public ActionResult Edit(int id)
        {
            var slide =  _slideService.Edit(id);
            if (slide == null)
            {
                TempData["warning"] = "slide không tồn tại";
                return RedirectToAction("Index");
            }

            return View(slide);
        }

        // POST: SlideController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public ActionResult Edit(SlideUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result =  _slideService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật slide thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật slide thất bại");
                TempData["error"] = "Cập nhật slide thất bại";
                return View(request);
            }
        }

        // GET: SlideController/Delete/5
        public ActionResult Delete(int id)
        {
            var model =  _slideService.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Slide không tồn tại";
                return RedirectToAction("Index");
            }
            var result =  _slideService.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa Slide thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa Slide thất bại";
            return RedirectToAction("Index");
        }

      
    }
}
