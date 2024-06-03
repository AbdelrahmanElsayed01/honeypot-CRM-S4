// Models/Quote.cs
namespace HoneypotCRMS4.Models
{
    public class QuoteModel
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public decimal QuoteSum { get; set; }
        public string PaymentStatus { get; set; }

        public QuoteModel(int id, string customerName, decimal quoteSum, string paymentStatus)
        {
            ID = id;
            CustomerName = customerName;
            QuoteSum = quoteSum;
            PaymentStatus = paymentStatus;
        }

        public QuoteModel()
        {
        }
    }
}
