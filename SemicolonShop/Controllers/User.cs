using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemicolonShop.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Editprofile()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
    }
}
