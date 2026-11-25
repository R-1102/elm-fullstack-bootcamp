using Microsoft.AspNetCore.Mvc;
using AmazonOMS_.Models;

namespace AmazonOMS_.Controllers
{
    public class OrderController : Controller
    {
        private static List<Order> orders = new();

        [HttpGet("/Orders/{userId}")]
        public IActionResult History(int userId)
        {
            var userOrders = orders.Where(o => o.UserId == userId).ToList();
            return View(userOrders);
        }

        [HttpGet("/Order/Place")]
        public IActionResult PlaceOrder()
        {
            return View();
        }

        [HttpPost("/Order/Place")]
        public IActionResult PlaceOrder(int userId, int productId, int quantity)
        {
            if (quantity <= 0) return BadRequest("Quantity must be greater than zero.");

            var newOrder = new Order
            {
                Id = orders.Count + 1,
                UserId = userId,
                OrderDetails = new List<OrderDetails>
                {
                    new OrderDetails { Id = orders.Count + 1, OrderId = orders.Count + 1, ProductId = productId, Quantity = quantity }
                }
            };

            orders.Add(newOrder);
            return RedirectToAction("History", new { userId = userId });
        }
    }
}
