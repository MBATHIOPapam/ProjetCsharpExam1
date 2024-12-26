using Microsoft.AspNetCore.Mvc;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        public IActionResult Index()
        {
            var produits = _produitService.GetAllProduits();
            return View(produits);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produit produit)
        {
            if (ModelState.IsValid)
            {
                _produitService.CreateProduit(produit);
                return RedirectToAction(nameof(Index));
            }
            return View(produit); // Return the view with the produit data if model state is invalid
        }
    }
}

