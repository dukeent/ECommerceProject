using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("Order_Customer")]
        public int CustomerId { get; set; }
        public User Customer { get; set; }
    }
}
