using P227Pronia.Models;
using System.Collections.Generic;

namespace P227Pronia.ViewModels.Products
{
    public class ProductDetailVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SellPrice { get; set; }
        public int Raiting { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
    }
}
