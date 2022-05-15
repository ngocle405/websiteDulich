using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.News;
using WebAppDulich.Data;
using WebAppDulich.Services;

namespace WebAppDulich.Areas.Admin.Controllers
{
    [Area("admin")]
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly ICategoryNewService _categoryNewsService;
        private IHostingEnvironment _env;

        public NewsController(INewsService newsService, ICategoryNewService categoryNewsService, IHostingEnvironment env)
        {
            _newsService = newsService;
            _categoryNewsService = categoryNewsService;
            _env = env;
        }
        // GET: NewsController
        public ActionResult Index()
        {
            var lstNews =  _newsService.GetAll();
            ViewBag.lstNews = lstNews;
            return View();
        }
        public SelectList loadCategory()
        {
            IEnumerable<CategoriesNew> categories = _categoryNewsService.GetAll();
            // categories.Insert(0, new CategoryNewsViewModel { Id = -1, Name = "-- Chọn danh mục --" });
            SelectList categoryList = new SelectList(categories, "Id", "Name");
            ViewBag.categoryList = categoryList;
            return categoryList;
        }
        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        public ActionResult Create()
        {
            loadCategory();
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public ActionResult Create(NewsCreateRequest request)
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

            var result = _newsService.Create(request);

            if (result != -1)
            {
                TempData["success"] = "Thêm mới bài viết thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm bài viết thất bại");
            TempData["error"] = "Thêm mới bài viết thất bại";
            return View(request);
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            var news = _newsService.Edit(id);
            if (news == null)
            {
                TempData["warning"] = "Bài viết không tồn tại";
                return RedirectToAction("Index");
            }

            loadCategory();
            return View(news);
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Consumes("multipart/form-data")]
        public ActionResult Edit(NewsUpdateRequest request)
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

            var result = _newsService.Update(request);

            if (result == 1)
            {
                TempData["success"] = "Cập nhật bài viết thành công";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Cập nhật bài viết thất bại");
                TempData["error"] = "Cập nhật bài viết thất bại";
                return View(request);
            }
        }

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _newsService.Detail(id);
            if (model == null)
            {
                TempData["warning"] = "Bài viết không tồn tại";
                return RedirectToAction("Index");
            }
            var result = _newsService.Delete(id);
            if (result == 1)
            {
                TempData["success"] = "Xóa bài viết thành công";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Xóa bài viết thất bại";
            return RedirectToAction("Index");
        }


    }
}
