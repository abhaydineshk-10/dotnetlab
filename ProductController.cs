using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name= "Laptop", Price= 60000, Quantity=500 },
                new Product { Id = 2, Name= "Mobile", Price= 30000, Quantity=300 },
                new Product { Id = 3, Name= "Headphones", Price= 3000, Quantity= 700}
            };

            return View(products);
        }
    }
}
