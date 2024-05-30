using System;

namespace HoneypotCRMS4.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }

        public OrderModel()
        {
        }
    }
}
