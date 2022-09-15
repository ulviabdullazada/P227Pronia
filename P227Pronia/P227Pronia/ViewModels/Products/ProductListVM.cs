using P227Pronia.Models;
using System.Collections.Generic;

namespace P227Pronia.ViewModels.Products
{
    public class ProductListVM
    {
        public IEnumerable<Product> Products;
        public IEnumerable<Color> Colors;
        public int ProductCount;
    }
}
