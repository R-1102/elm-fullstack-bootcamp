namespace AmazonOMS.Models
{
	public class Order
	{
		public int OrderID { get; set; }
		public int UserID { get; set; }
		public DateTime OrderDate { get; set; }
		public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>(); // Make sure it's initialized
	}
}