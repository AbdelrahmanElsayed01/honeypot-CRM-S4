using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;
using HoneypotCRMS4.Data;
using Microsoft.AspNetCore.Authorization;
namespace HoneypotCRMS4.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly ILogger<UserController> _logger;
        private DataHelper dh = new DataHelper();

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Index()
        {
            var viewModel = new UserViewModel()
            {
                Users = dh.GetUsers(),
                NewUser = new UserModel()
            };
            return View(viewModel);
        }

 // POST: Users/Create
        [HttpPost]
        public ActionResult Index(UserViewModel viewModel)
        {
            
            
            if (viewModel.NewUser != null)
            {
                dh.AddUser(viewModel.NewUser);
                return RedirectToAction("Index");
            }
            viewModel.Users = dh.GetUsers(); // Ensure the users list is re-populated in case of validation failure
            return View(viewModel);
        }
/*
        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var user = users.Find(u => u.Id == id);
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = users.Find(u => u.Id == user.Id);
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Role = user.Role;
                return RedirectToAction("Index");
            }
            return View(user);
        }
*/
        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            var Users = dh.GetUsers();
            var user = Users.Find(u => u.Id == id);
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var Users = dh.GetUsers();
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
            dh.DeleteUser(id);
            return RedirectToAction("Index");
        }
   
        public string CheckConnection()
        {
            DataHelper dh = new DataHelper();
            return dh.CheckConnection();
        }

        public List<UserModel> GetUsers()
        {
            DataHelper dh = new DataHelper();
            return dh.GetUsers();
        }

        public IActionResult Register(UserModel user)
        {
            // Call the Register method from your repository
            dh.Register(user);

            // Show a success message
            TempData["Message"] = "Registration successful";

            // Redirect to a success page or any other action
            return RedirectToAction("Index", "Home");
        }

    }
}
