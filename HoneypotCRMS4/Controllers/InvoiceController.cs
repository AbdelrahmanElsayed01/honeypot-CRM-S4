using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;
using System.Linq;
using System.Threading.Tasks;
using HoneypotCRMS4.Data;   

namespace HoneypotCRMS4.Controllers
{
    public class InvoiceController : Controller
    {

        private readonly ILogger<InvoiceController> _logger;
        private DataHelper dh = new DataHelper();

        public InvoiceController(ILogger<InvoiceController> logger)
        {
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            var invoices = dh.GetInvoices();
            return View(invoices);
        }

    
    }
}
