using Microsoft.AspNetCore.Mvc;
using AmazonOMS.Models;

namespace AmazonOMS.Controllers
{
    public class OrdersController : Controller
    {
        private static List<Product> products = ProductsController.Products;

        private static List<Order> orders = new List<Order>();

        [HttpGet]
        public IActionResult Create(int id)
        {
            // Retrieve the product based on the provided ID
            var product = products.FirstOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return NotFound(); // Return a 404 error if the product is not found
            }

            var order = new Order
            {
                OrderDate = DateTime.Now,
                OrderDetails = new List<OrderDetail>
                {
                    new OrderDetail
                    {
                        ProductID = id,
                        Quantity = 1,
                        SubTotal = product.Price
                    }
                }
            };

            ViewBag.Products = products;
            ViewBag.Product = product;

            return View(order);
        }


        [HttpPost]
        public IActionResult Create(int productID, int quantity) // Make sure parameter names match the form input names
        {
            var product = products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null && quantity > 0 && product.StockQuantity >= quantity)
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

            ViewBag.Products = products;
            ViewBag.Product = product;
            ModelState.AddModelError(string.Empty, "Invalid quantity or insufficient stock.");
            return View(new Order { OrderDate = DateTime.Now });
        }


        public IActionResult History(int userId)
        {
            var userOrders = orders.Where(o => o.UserID == userId).ToList();
            ViewBag.Products = products;
            return View(userOrders);
        }
    }
}
