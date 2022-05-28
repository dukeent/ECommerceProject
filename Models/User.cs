using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string dob{ get; set; }
        public string username { get; set; }
        public string password { get; set; }

        // Foreign key   
        [Display(Name = "Role")]
        public virtual int role_id { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Role roles { get; set; }

    }
}
