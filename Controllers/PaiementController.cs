using Microsoft.AspNetCore.Mvc;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Controllers
{
    public class PaiementController : Controller
    {
        private readonly IPaiementService _paiementService;

        public PaiementController(IPaiementService paiementService)
        {
            _paiementService = paiementService;
        }

        public IActionResult Index()
        {
            var paiements = _paiementService.GetAllPaiements();
            return View(paiements);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paiement paiement)
        {
            if (ModelState.IsValid)
            {
                _paiementService.CreatePaiement(paiement);
                return RedirectToAction(nameof(Index));
            }
            return View(paiement); // Return the view with the paiement data if model state is invalid
        }
    }
}

