using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.CategoryNews;
using WebAppDulich.Services;

namespace WebAppDulich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryNewsController : Controller
    {
        private readonly ICategoryNewService _categoryNewService;
        public CategoryNewsController(ICategoryNewService categoryNewService)
        {
            _categoryNewService = categoryNewService;
        }
        // GET: CategoryNewsController
        public ActionResult Index()
        {
            var lst = _categoryNewService.GetAll();
            ViewBag.lst = lst;
            return View();
        }

        // GET: CategoryNewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryNewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryNewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryNewsRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result =  _categoryNewService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới danh mục bài viết thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm danh mục bài viết thất bại");
            TempData["error"] = "Thêm mới danh mục bài viết thất bại";
            return View(request);
        }

        // GET: CategoryNewsController/Edit/5
        public ActionResult Edit(int id)
        {
            var category =  _categoryNewService.Edit(id);
            if (category == null)
            {
                TempData["warning"] = "Danh mục không tồn tại";
                return RedirectToAction("Index");
            }

            return View(category);
        }

        // POST: CategoryNewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryNewsRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result = _categoryNewService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật danh mục bài viết thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật danh mục bài viết thất bại");
                TempData["error"] = "Cập nhật danh mục bài viết thất bại";
                return View(request);
            }
        }

        // GET: CategoryNewsController/Delete/5
        public ActionResult Delete(int id)
        {
            var model =  _categoryNewService.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Danh mục không tồn tại";
                return RedirectToAction("Index");
            }

            var result =  _categoryNewService.Delete(id);
            if (result != 1)
            {
                TempData["warning"] = "Danh mục chứa bài viết ko thể xóa";
                ModelState.AddModelError("", "Danh mục chứa bài viết ko thể xóa");
                return RedirectToAction("Index");
            }
            TempData["success"] = "Xóa danh mục thành công";
            return RedirectToAction("Index");
        }

      
    }
}
