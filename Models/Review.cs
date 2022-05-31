namespace ECommerceProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int ReviewStar { get; set; }
        public string ReviewComment { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
