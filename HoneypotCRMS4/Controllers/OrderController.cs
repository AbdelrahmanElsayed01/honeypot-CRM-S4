using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Cmp;
using HoneypotCRMS4.Data;

namespace ClientPortal.Controllers
{
    public class OrderController : Controller
    {

         private readonly ILogger<OrderController> _logger;
        private DataHelper dh = new DataHelper();

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            // This should be replaced with a call to your database to fetch the real data
            var orders = dh.GetOrders();

            return View(orders);
        }
    }
}
