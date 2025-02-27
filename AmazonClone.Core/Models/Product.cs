namespace AmazonClone.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public List<string> ImageUrls { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public List<string> Reviews { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFeatured { get; set; }
        public string Seller { get; set; }
        public bool IsAvailablePrime { get; set; } // Changed from string to bool
    }
}