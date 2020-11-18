using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SemicolonShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace SemicolonShop.Controllers
{
    public class HomeController : Controller
    {
        [NonAction]
        public List<User> GetLoginUserList()
        {
            return new List<User>{
      new User{
         UserID =1,
         UFirstName= "aaa",
         ULastName="bbb",
         UserName="admin",
         Password= "1234"
      },
            new User{
         UserID =2,
         UFirstName= "faii",
         ULastName="chann",
         UserName="faiichann",
         Password= "1111"
      },
   };
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Admin()
        {
            ViewBag.Username = "Admin";
            return View();
        }
        public IActionResult Home()
        {
            ViewBag.Username = "User";
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.Username = "User";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login()
        {
            string btnCick = HttpContext.Request.Form["Login"].ToString();
            if (btnCick == "Login")
            {
                string Username = HttpContext.Request.Form["username"].ToString();
                string Password = HttpContext.Request.Form["password"].ToString();
                //var login = (from e in GetLoginUserList()
                //             where e.UserName == Username &&
                //             e.Password == Password
                //             select e).FirstOrDefault();
               // if (login != null)
               // {
                    if (Username == "admin" && Password == "1234")
                    {
                        
                        return RedirectToAction("Admin");
                    }
                    else
                    {
                        
                        return RedirectToAction("Home");
                    }
                //}
               // else
                   // return View("Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                //db.Add(user);
                //await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
