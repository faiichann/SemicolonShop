using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SemicolonShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;

namespace SemicolonShop.Controllers
{
    public class HomeController : Controller
    {
   //     [NonAction]
   //     public List<User> GetLoginUserList()
   //     {
   //         return new List<User>{
   //   new User{
   //      UserID =1,
   //      UFirstName= "aaa",
   //      ULastName="bbb",
   //      UserName="admin",
   //      Password= "1234"
   //   },
   //         new User{
   //      UserID =2,
   //      UFirstName= "faii",
   //      ULastName="chann",
   //      UserName="faiichann",
   //      Password= "1111"
   //   },
   //};
   //     }

   //     public List<Product> GetProduct()
   //     {
   //         List<Product> pd = new List<Product>();
   //         pd.Add(new Product { ProductID = 1, ProductType = "Vet", ProductName = "carrot", ProductPrice = "20" , ProductUnit = "15" , DateUpdate = "12/02/12"});
   //         pd.Add(new Product { ProductID = 2, ProductType = "Me", ProductName = "pig", ProductPrice = "120", ProductUnit = "30", DateUpdate = "12/02/12" });
   //         pd.Add(new Product { ProductID = 3, ProductType = "Vet", ProductName = "onion", ProductPrice = "53", ProductUnit = "30", DateUpdate = "12/02/12" });
   //         return pd;
   //     }

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Admin()
        //{
        //    ViewBag.Username = "Admin";;
        //    ViewBag.Product = GetProduct();
        //    return View();
        //}
        //public IActionResult Home()
        //{
        //    ViewBag.Username = "User";
        //    return View();
        //}
        //public IActionResult Register()
        //{
        //    ViewBag.Username = "User";
        //    return View();
        //}

        //public IActionResult Add()
        //{
        //    ViewBag.Product = GetProduct();
        //    return View();
        //}
        //public IActionResult Edit()
        //{
        //    ViewBag.Product = GetProduct();
        //    return View();
        //}
        //public IActionResult Delete()
        //{
        //    ViewBag.Product = GetProduct();
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Add([Bind("ProductID,ProductType,ProductName,ProductPrice,ProductUnit")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Admin));
        //    }
        //    return View(product);
        //}

        //// GET: CRUD/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Product.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}

        //// POST: CRUD/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ProductID,ProductType,ProductName,ProductPrice,ProductUnit")] Product product)
        //{
        //    if (id != product.ProductID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(product);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductExists(product.ProductID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(product);
        //}

        //// GET: CRUD/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Product
        //        .FirstOrDefaultAsync(m => m.ProductID == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(product);
        //}

        //// POST: CRUD/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var product = await _context.Product.FindAsync(id);
        //    _context.Product.Remove(product);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Login()
        //{
        //    string btnCick = HttpContext.Request.Form["Login"].ToString();
        //    if (btnCick == "Login")
        //    {
        //        string Username = HttpContext.Request.Form["username"].ToString();
        //        string Password = HttpContext.Request.Form["password"].ToString();
        //        //var login = (from e in GetLoginUserList()
        //        //             where e.UserName == Username &&
        //        //             e.Password == Password
        //        //             select e).FirstOrDefault();
        //       // if (login != null)
        //       // {
        //            if (Username == "admin" && Password == "1234")
        //            {
                        
        //                return RedirectToAction("Admin");
        //            }
        //            else
        //            {
                        
        //                return RedirectToAction("Home");
        //            }
        //        //}
        //       // else
        //           // return View("Index");
        //    }
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Register(User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //db.Add(user);
        //        //await db.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(user);
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
