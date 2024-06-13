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

        [Required]
        public string Password { get; set; }

        public UserModel()
        {
        }

        // Constructor with parameters
        public UserModel(int id, string name, string email, string role, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Role = role;
            Password = password;
        }
        
    }

}

