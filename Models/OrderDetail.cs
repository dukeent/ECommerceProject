using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
