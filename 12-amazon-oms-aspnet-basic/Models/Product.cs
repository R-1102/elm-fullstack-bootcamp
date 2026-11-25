using System.ComponentModel.DataAnnotations; // Required for [Required] and [Range] attributes

namespace AmazonOMS_.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required] // Ensures Name cannot be null or empty
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        public decimal Price { get; set; }
    }
}
