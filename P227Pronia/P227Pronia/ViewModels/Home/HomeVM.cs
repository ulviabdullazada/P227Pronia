using P227Pronia.Models;
using System.Collections.Generic;

namespace P227Pronia.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Product> Features{ get; set; }
        public IEnumerable<Product> BestSellers { get; set; }
        public IEnumerable<Product> Lastests { get; set; }
    }
}
