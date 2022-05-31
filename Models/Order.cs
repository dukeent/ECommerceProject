using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
    }
}
