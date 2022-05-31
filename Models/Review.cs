namespace ECommerceProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int ReviewStar { get; set; }
        public string ReviewComment { get; set; }

        [ForeignKey("Review_Customer")]
        public int CustomerId { get; set; }
        public User Customer { get; set; }

    }
}
