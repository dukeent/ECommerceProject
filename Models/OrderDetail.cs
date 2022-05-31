﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        
        [ForeignKey("OrderDetail_Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        [ForeignKey("OrderDetail_Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
