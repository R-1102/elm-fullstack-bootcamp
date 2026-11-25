namespace AmazonOMS_.Models
{

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}