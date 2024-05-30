using System.ComponentModel.DataAnnotations;

namespace HoneypotCRMS4.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public ClientModel()
        {
        }

        // Constructor with parameters
        public ClientModel(int id, string name, string email, string companyName)
        {
            Id = id;
            Name = name;
            Email = email;
            CompanyName = companyName;
        }
        
    }

}

