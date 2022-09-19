using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P227Pronia.DAL;
using P227Pronia.Models;
using P227Pronia.ViewModels.Home;
using System.Collections.Generic;
using System.Linq;

namespace P227Pronia.Controllers
{
    public class HomeController : Controller
    {
        ProniaContext _context;
        public HomeController(ProniaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productQuery = _context.Products.Take(8).Include(p => p.ProductImages);
            HomeVM vm = new HomeVM();
            vm.Sliders = _context.Sliders.OrderBy(x=>x.Order);
            vm.Services = _context.Services.Where(x => x.IsActive);
            vm.Features = productQuery;
            vm.BestSellers = productQuery.OrderByDescending(p => p.SoldCount);
            vm.Lastests = productQuery.OrderByDescending(p => p.CreatedTime);
            return View(vm);
        }
        public IActionResult GetSession(string key) 
        {
            return Content(HttpContext.Session.GetString(key));
        }
        public IActionResult SetSession(string value)
        {
            HttpContext.Session.SetString("name", value);
            return Content("Ok");
        }
        public IActionResult GetCookie()
        {
            return Content(HttpContext.Request.Cookies["basket"]);
        }
        
    }
}
