namespace HoneypotCRMS4.Models
{
    public class ClientViewModel
    {
        public IEnumerable<ClientModel> Clients { get; set; }
        public ClientModel NewClient { get; set; }
    }
}
