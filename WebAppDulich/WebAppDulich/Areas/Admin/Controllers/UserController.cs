using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDulich.Areas.Admin.Models.Authen;
using WebAppDulich.Data;

namespace WebAppDulich.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private TravelContext _travelContext;

        public UserController(TravelContext travelContext)
        {
            _travelContext = travelContext;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string PasswordHash,string UserName)
        {
            var res = _travelContext.AspNetUsers.Count(x => x.UserName == UserName && x.PasswordHash == PasswordHash);
            if (string.IsNullOrEmpty(PasswordHash ))
            {
                ViewBag.error = "Mật khẩu không được để trống";
            }
            else
            if (string.IsNullOrEmpty(UserName))
            {
                ViewBag.error = "Tài khoản không được để trống";
            }
            else 

            if (PasswordHash != null && UserName != null && res > 0)
            {
                HttpContext.Session.SetString("Token", JsonConvert.SerializeObject(res));
                return RedirectToAction("index","tour");
            }
            else
            {
                ViewBag.error = "Tài khoản hoặc mật khẩu chưa chính xác";
            }
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Token");
            return Redirect("/Admin/User/Login");
        }
    }
}
