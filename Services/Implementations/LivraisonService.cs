using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Services.Implementations
{
    public class LivraisonService : ILivraisonService
    {
        private readonly ApplicationDbContext _context;

        public LivraisonService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateLivraison(Livraison livraison)
        {
            _context.Livraisons.Add(livraison);
            _context.SaveChanges();
        }

        public Livraison GetLivraisonById(int id)
        {
            var livraison = _context.Livraisons.Find(id);
            if (livraison == null)
            {
                // Handle the case where the livraison is not found
                throw new KeyNotFoundException($"Livraison with ID {id} not found.");
            }
            return livraison;
        }

        public IEnumerable<Livraison> GetAllLivraisons()
        {
            return _context.Livraisons.ToList();
        }

        public void UpdateLivraison(Livraison livraison)
        {
            _context.Livraisons.Update(livraison);
            _context.SaveChanges();
        }

        public void DeleteLivraison(int id)
        {
            var livraison = GetLivraisonById(id);
            if (livraison != null)
            {
                _context.Livraisons.Remove(livraison);
                _context.SaveChanges();
            }
        }
    }
}

