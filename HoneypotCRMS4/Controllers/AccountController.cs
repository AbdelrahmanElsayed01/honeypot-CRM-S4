using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;
using HoneypotCRMS4.Data;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace HoneypotCRMS4.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataHelper _dataHelper;

        public AccountController()
        {
            _dataHelper = new DataHelper();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    [HttpPost]
    public async Task<IActionResult> Index(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            var user = _dataHelper.AuthenticateUser(model.Username, model.Password);
            if (user != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Email, user.Email)
                };
                var identity = new ClaimsIdentity(claims, "CookieAuth");
                var claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("CookieAuth", claimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
        }
        return View(model);
    }
    
    
    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuth");
            return RedirectToAction("Index", "Account");
        }

        

    }
}

