using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.Category;
using WebAppDulich.Services;

namespace WebAppDulich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : CheckLoginController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var lstCategories = _categoryService.GetAll();
            ViewBag.lstCategories = lstCategories;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryRequest request)
        {
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            var result =  _categoryService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới loại tour thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm loại tour thất bại");
            TempData["error"] = "Thêm loại tour thất bại";
            return View(request);
        }

        public IActionResult Edit(long id)
        {
           
            var category =  _categoryService.Edit(id);
            if (category == null)
            {
                TempData["warning"] = "Loại tour không tồn tại";
                return RedirectToAction("Index");
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(CategoryRequest request)
        {
           // await loadCategoryEdit(request.Id);
            if (!ModelState.IsValid)
            {
                TempData["warning"] = "Bạn nhập thiếu dữ liệu";
                return View(request);
            }

            if (request.ParentId == -1)
            {
                request.ParentId = null;
            }

            var result =  _categoryService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật danh mục sản phẩm thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật danh mục sản phẩm thất bại");
                TempData["error"] = "Cập nhật danh mục sản phẩm thất bại";
                return View(request);
            }
        }
       
        public IActionResult Delete(long id)
        {
            var model =  _categoryService.Edit(id);
            if (model == null)
            {
                TempData["warning"] = "Danh mục không tồn tại";
                return RedirectToAction("Index");
            }

            var result =  _categoryService.Delete(id);
            if (result != 1)
            {
                TempData["warning"] = "Danh mục chứa sản phẩm ko thể xóa";
                ModelState.AddModelError("", "Danh mục chứa sản phẩm ko thể xóa");
                return RedirectToAction("Index");
            }
            TempData["success"] = "Xóa danh mục thành công";
            return RedirectToAction("Index");
        }
    }
}
