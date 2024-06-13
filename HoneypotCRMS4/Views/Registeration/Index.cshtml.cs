using Microsoft.AspNetCore.Mvc.RazorPages;
using HoneypotCRMS4.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoneypotCRMS4.Views.Registeration
{
    public class IndexModel : PageModel
    {
        public UserModel User { get; set; }

        public void OnGet()
        {
            User = new UserModel();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Handle registration logic here (e.g., save to database)

            // Redirect to a success page or any other action
            return RedirectToPage("/Index");
        }
    }
}

