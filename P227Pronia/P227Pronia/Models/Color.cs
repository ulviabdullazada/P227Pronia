using System.Collections.Generic;

namespace P227Pronia.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
    }
}
