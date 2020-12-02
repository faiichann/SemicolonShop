using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemicolonShop.Controllers
{
    public class profileuser : Controller
    {
        public IActionResult Personal()
        {
            return View();
        }
        public IActionResult Address()
        {
            return View();
        }
        public IActionResult Orderlist()
        {
            return View();
        }
        public IActionResult ChangePersonal()
        {
            return View();
        }
        public IActionResult ChangeAddress()
        {
            return View();
        }
    }
}
