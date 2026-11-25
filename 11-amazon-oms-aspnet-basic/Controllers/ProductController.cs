using Microsoft.AspNetCore.Mvc;
using AmazonOMS_.Models;

namespace AmazonOMS_.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500, Description = "High performance laptop" },
            new Product { Id = 2, Name = "Smartphone", Price = 800, Description = "Latest model smartphone" }
        };

        [HttpGet("/Products")]
        public IActionResult Index()
        {
            return View(products);
        }
    }
}
