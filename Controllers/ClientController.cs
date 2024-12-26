using Microsoft.AspNetCore.Mvc;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            var clients = _clientService.GetAllClients();
            return View(clients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _clientService.CreateClient(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client); // Return the view with the client data if model state is invalid
        }
    }
}

