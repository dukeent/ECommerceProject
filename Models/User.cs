namespace ECommerceProject.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        [ForeignKey("User_Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;

    }
}
