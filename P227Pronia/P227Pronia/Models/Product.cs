using System.Collections.Generic;

namespace P227Pronia.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description{ get; set; }
        public decimal SellPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int Raiting { get; set; }
        public string Barcode { get; set; }
        public int SoldCount { get; set; }
        public ICollection<ProductImage> ProductImages{ get; set; }
        public ICollection<ProductColor> ProductColors{ get; set; }
    }
}
