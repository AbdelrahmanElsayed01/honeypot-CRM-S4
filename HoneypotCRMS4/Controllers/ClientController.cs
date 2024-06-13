using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HoneypotCRMS4.Models;
using HoneypotCRMS4.Data;
using Microsoft.AspNetCore.Authorization;
namespace HoneypotCRMS4.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {


        private readonly ILogger<ClientController> _logger;
        private DataHelper dh = new DataHelper();

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Index()
        {
            var viewModel = new ClientViewModel()
            {
                Clients = dh.GetClients(),
                NewClient = new ClientModel()
            };
            return View(viewModel);
        }

 // POST: Users/Create
        [HttpPost]
        public ActionResult Index(ClientViewModel viewModel)
        {
            
            
            if (viewModel.NewClient != null)
            {
                dh.AddClient(viewModel.NewClient);
                return RedirectToAction("Index");
            }
            viewModel.Clients = dh.GetClients(); // Ensure the users list is re-populated in case of validation failure
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
            var clients = dh.GetClients();
            var client = clients.Find(u => u.Id == id);
            return View(client);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var clients = dh.GetClients();
            var client = clients.Find(u => u.Id == id);
            clients.Remove(client);
            dh.DeleteClient(id);
            return RedirectToAction("Index");
        }
   
        public string CheckConnection()
        {
            DataHelper dh = new DataHelper();
            return dh.CheckConnection();
        }

        public List<ClientModel> GetClients()
        {
            DataHelper dh = new DataHelper();
            return dh.GetClients();
        }

    }
}
