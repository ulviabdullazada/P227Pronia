using Microsoft.EntityFrameworkCore;
using P227Pronia.Models;

namespace P227Pronia.DAL
{
    public class ProniaContext:DbContext
    {
        public ProniaContext(DbContextOptions<ProniaContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
    }
}
