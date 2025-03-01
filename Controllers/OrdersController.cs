using Microsoft.AspNetCore.Mvc;
using AmazonOMS.Models;

namespace AmazonOMS.Controllers
{
    public class OrdersController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Dell XPS 13", Category = "Electronics", Price = 1200.00m, StockQuantity = 10 },
            new Product { ProductID = 2, Name = "MacBook Pro 16", Category = "Electronics", Price = 2500.00m, StockQuantity = 5 }
        };

        private static List<Order> orders = new List<Order>();

        public IActionResult Create(int id)
        {
            // Retrieve the product based on the provided ID
            var product = products.FirstOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return NotFound(); // Return a 404 error if the product is not found
            }

            // Create an order with an empty order details list
            var order = new Order
            {
                OrderDetails = new List<OrderDetail> // Initialize with an empty list of OrderDetails
     
            {
                new OrderDetail
                {
                    ProductID = ProductID,
                    Quantity = Quantity,
                    SubTotal = product.Price * Quantity
                }
             }
             };

        // Pass the product to the view
        ViewBag.Product = product;

            return View(order);
        }


        [HttpPost]
        public IActionResult Create(int productID, int quantity) // Make sure parameter names match the form input names
        {
            var product = products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null && product.StockQuantity >= quantity)
            {
                var order = new Order
                {
                    UserID = 1,
                    OrderID = orders.Count + 1,
                    OrderDate = DateTime.Now,
                    OrderDetails = new List<OrderDetail>
            {
                new OrderDetail
                {
                    ProductID = productID,
                    Quantity = quantity,
                    SubTotal = product.Price * quantity
                }
            }
                };

                orders.Add(order);
                product.StockQuantity -= quantity; // Update stock quantity

                return RedirectToAction("History", new { userId = 1 });
            }

            return View();
        }


        public IActionResult History(int userId)
        {
            var userOrders = orders.Where(o => o.UserID == userId).ToList();
            return View(userOrders);
        }
    }
}
