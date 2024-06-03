// Controllers/QuotesController.cs
using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;
using System.Collections.Generic;
using System.Linq;
using HoneypotCRMS4.Data;
namespace HoneypotCRMS4.Controllers
{
    public class QuoteController : Controller
    {
        private readonly ILogger<QuoteController> _logger;
        private DataHelper dh = new DataHelper();

        public QuoteController(ILogger<QuoteController> logger)
        {
            _logger = logger;
        }

        // GET: Quotes
        public IActionResult Index()
        {
            var quotes = dh.GetQuotes();
            return View(quotes);
        }

        public List<QuoteModel> GetQuotes()
        {
            return dh.GetQuotes();
        }
        
        
    }
}
