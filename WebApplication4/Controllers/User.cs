using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    public class User : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username.Equals("admin") && password == "123123")
            {
                return RedirectToAction("Index","Product");
            }
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
