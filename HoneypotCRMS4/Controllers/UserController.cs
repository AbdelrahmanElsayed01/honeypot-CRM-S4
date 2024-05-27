using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;

namespace HoneypotCRMS4.Controllers
{
    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

       List<UserModel> users = new List<UserModel>();

        public IActionResult Index()
        {
            return View();
        }




    }
}
