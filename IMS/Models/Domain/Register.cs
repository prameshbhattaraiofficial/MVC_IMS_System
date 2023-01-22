using System.ComponentModel.DataAnnotations;

namespace IMS.Models.Domain
{
    public class Register
    {
        [Key]
        public int ID { get; set; }
        [Required]
        

        public String name { get; set; }
        
        public String address { get; set;}

        public String gender { get; set;}

        public String Contact { get; set;}

        public DateTime Dob { get; set;}

        public String email { get; set;}

        public String password { get; set;}

      

    
    }
}
