using System;
using System.ComponentModel.DataAnnotations;
using Humanizer;

namespace HoneypotCRMS4.Models
{
    public class InvoiceModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }


        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [StringLength(500)]
        public string Status { get; set; }

        public InvoiceModel()
        {
        }
    }
}
