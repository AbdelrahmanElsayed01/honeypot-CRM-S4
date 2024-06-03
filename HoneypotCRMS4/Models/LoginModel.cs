using System.ComponentModel.DataAnnotations;

namespace HoneypotCRMS4.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Username cannot be longer than 100 characters.")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
