namespace ECommerceProject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double Price { get; set; }
        public int Quantity { get; set; }


        [ForeignKey("Product_Review")]
        public int ReviewId { get; set; }
        public Review Review { get; set; } = null!;
    }
}
