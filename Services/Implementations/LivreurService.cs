using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Services.Implementations
{
    public class LivreurService : ILivreurService
    {
        private readonly ApplicationDbContext _context;

        public LivreurService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateLivreur(Livreur livreur)
        {
            _context.Livreurs.Add(livreur);
            _context.SaveChanges();
        }

        public Livreur GetLivreurById(int id)
        {
            var livreur = _context.Livreurs.Find(id);
            if (livreur == null)
            {
                // Handle the case where the livreur is not found
                throw new KeyNotFoundException($"Livreur with ID {id} not found.");
            }
            return livreur;
        }

        public IEnumerable<Livreur> GetAllLivreurs()
        {
            return _context.Livreurs.ToList();
        }

        public void UpdateLivreur(Livreur livreur)
        {
            _context.Livreurs.Update(livreur);
            _context.SaveChanges();
        }

        public void DeleteLivreur(int id)
        {
            var livreur = GetLivreurById(id);
            if (livreur != null)
            {
                _context.Livreurs.Remove(livreur);
                _context.SaveChanges();
            }
        }
    }
}
