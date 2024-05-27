using System.ComponentModel.DataAnnotations;

namespace HoneypotCRMS4.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }
        
    }

}

