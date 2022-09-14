using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            HomeVM vm = new HomeVM();
            vm.Sliders = _context.Sliders.OrderBy(x=>x.Order);
            vm.Services = _context.Services.Where(x => x.IsActive);
            vm.Features = _context.Products.Take(8).Include(p=>p.ProductImages);
            vm.BestSellers = _context.Products.OrderByDescending(p => p.SoldCount).Take(8).Include(p => p.ProductImages);
            vm.Lastests = _context.Products.OrderByDescending(p => p.CreatedTime).Take(8).Include(p => p.ProductImages);
            return View(vm);
        }
    }
}
