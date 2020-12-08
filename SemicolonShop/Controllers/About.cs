using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemicolonShop.Controllers
{
    public class About : Controller
    {
        public IActionResult Aboutus()
        {
            return View();
        }
    }
}
