﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SemicolonShop.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Data()
        {
            return View();
        }
        public IActionResult Editproduct()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
