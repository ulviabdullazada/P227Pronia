using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P227Pronia.DAL;
using P227Pronia.Models;
using P227Pronia.ViewModels.Products;
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
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Product product = await _context.Products.Where(p => p.Id == id)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductColors).ThenInclude(pc => pc.Color)
                .FirstOrDefaultAsync();
            return View(product);
        }
        public async Task<IActionResult> GetDataById(int? id)
        {
            if (id is null) return NotFound();
            var p = await _context.Products.Where(p=>p.Id == id).Include(p=>p.ProductImages).SingleOrDefaultAsync();
            if (p is null) return NotFound();
            ProductDetailVM product = new ProductDetailVM
            {
                Name = p.Name,
                Description = p.Description,
                Raiting = p.Raiting,
                SellPrice = p.SellPrice,
                ProductColors = p.ProductColors,
                ProductImages = p.ProductImages
            };
            return PartialView("_ProducModalPartialView",p);
        }
    }
}
