using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using P227Pronia.DAL;
using P227Pronia.Models;
using P227Pronia.ViewModels;
using P227Pronia.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P227Pronia.Controllers
{
    public class ProductController : Controller
    {
        ProniaContext _context { get; }

        public ProductController(ProniaContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? colorId)
        {
            var products = _context.Products.Include(p => p.ProductImages).AsQueryable();
            int count = products.Count();
            if (colorId != null)
            {
                products = products.Where(p => p.ProductColors.Any(pc=>pc.ColorId == colorId));
            }
            ProductListVM productListVM = new ProductListVM 
            {
                Products = products.ToList(),
                Colors = _context.Colors.Include(c=>c.ProductColors),
                ProductCount = count
            };
            return View(productListVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Product product = await _context.Products.Where(p => p.Id == id)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductColors).ThenInclude(pc => pc.Color)
                .FirstOrDefaultAsync();
            return View(product);
        }
        public IActionResult GetDataById(int? id)
        {
            if (id is null) return NotFound();
            Product product = _context.Products.Include(p=>p.ProductImages)
                .Include(p=>p.ProductColors).ThenInclude(pc=>pc.Color)
                .Where(p=>p.Id == id).FirstOrDefault();
            if (product is null) return NotFound();
            return PartialView("_ProductModalPartialView", product);
        }
        public IActionResult FilterProducts(ProductFilterVM filter)
        {
            var products = _context.Products.Include(p => p.ProductImages).AsQueryable
                ();
            if (filter.MinPrice > filter.MaxPrice) return BadRequest();
            if (filter.ColorId != 0)
            {
                products = products.Where(p=>p.ProductColors.Any(pc=>pc.ColorId == filter.ColorId));
            }
            products = products.Where(p => p.SellPrice >= filter.MinPrice && p.SellPrice <= filter.MaxPrice);
            if (products is null) return NotFound();
            return PartialView("_ProductFilterPartialView", products);
        }
        public IActionResult AddBasket(int id)
        {
            var cookieData = Request.Cookies["basket"];
            List<BasketItem> basketItems;
            if (cookieData is null)
            {
                basketItems = new List<BasketItem>();
            }
            else
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItem>>(cookieData);
            }
            BasketItem exsits = basketItems.Find(b => b.ProductId == id);
            if (exsits is null)
            {
                basketItems.Add(new BasketItem { ProductId = id, ProductCount = 1 });
            }
            else
            {
                exsits.ProductCount++;
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItems), new CookieOptions{MaxAge=TimeSpan.MaxValue });
            return Json(Request.Cookies["basket"]);
        }
    }
}
