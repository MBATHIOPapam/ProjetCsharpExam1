using Microsoft.AspNetCore.Mvc;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Controllers
{
    public class LivraisonController : Controller
    {
        private readonly ILivraisonService _livraisonService;

        public LivraisonController(ILivraisonService livraisonService)
        {
            _livraisonService = livraisonService;
        }

        public IActionResult Index()
        {
            var livraisons = _livraisonService.GetAllLivraisons();
            return View(livraisons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livraison livraison)
        {
            if (ModelState.IsValid)
            {
                _livraisonService.CreateLivraison(livraison);
                return RedirectToAction(nameof(Index));
            }
            return View(livraison); // Return the view with the livraison data if model state is invalid
        }
    }
}

