using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemicolonShop.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
