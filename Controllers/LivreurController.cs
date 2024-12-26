using Microsoft.AspNetCore.Mvc;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Controllers
{
    public class LivreurController : Controller
    {
        private readonly ILivreurService _livreurService;

        public LivreurController(ILivreurService livreurService)
        {
            _livreurService = livreurService;
        }

        public IActionResult Index()
        {
            var livreurs = _livreurService.GetAllLivreurs();
            return View(livreurs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livreur livreur)
        {
            if (ModelState.IsValid)
            {
                _livreurService.CreateLivreur(livreur);
                return RedirectToAction(nameof(Index));
            }
            return View(livreur); // Return the view with the livreur data if model state is invalid
        }
    }
}

