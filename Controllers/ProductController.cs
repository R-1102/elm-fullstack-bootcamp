using Microsoft.AspNetCore.Mvc;
using AmazonOMS.Models;

namespace AmazonOMS.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            // Sample data
            var products = new List<Product>
            {
                new Product { ProductID = 1, Name = "Dell XPS 13", Category = "Electronics", Price = 1200.00m, StockQuantity = 10 },
                new Product { ProductID = 2, Name = "MacBook Pro 16", Category = "Electronics", Price = 2500.00m, StockQuantity = 5 },
                new Product { ProductID = 3, Name = "Nike T-Shirt", Category = "Clothing", Price = 50.00m, StockQuantity = 20 },
                new Product { ProductID = 4, Name = "Adidas Sneakers", Category = "Clothing", Price = 120.00m, StockQuantity = 15 }
            };

            return View(products);
        }
    }
}
