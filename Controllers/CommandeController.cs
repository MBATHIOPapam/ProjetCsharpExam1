using Microsoft.AspNetCore.Mvc;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Controllers
{
    public class CommandeController : Controller
    {
        private readonly ICommandeService _commandeService;

        public CommandeController(ICommandeService commandeService)
        {
            _commandeService = commandeService;
        }

        public IActionResult Index()
        {
            var commandes = _commandeService.GetAllCommandes();
            return View(commandes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Commande commande)
        {
            if (ModelState.IsValid)
            {
                _commandeService.CreateCommande(commande);
                return RedirectToAction(nameof(Index));
            }
            return View(commande); // Return the view with the commande data if model state is invalid
        }

        [HttpPost]
        public IActionResult DeclareRecu(int id)
        {
            _commandeService.DeclareCommandeRecue(id);
            return RedirectToAction(nameof(Index));
        }
}

}

