using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Services.Implementations
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly ApplicationDbContext _context;

        public UtilisateurService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateUtilisateur(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            _context.SaveChanges();
        }

        public Utilisateur GetUtilisateurById(int id)
        {
            var utilisateur = _context.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                // Handle the case where the utilisateur is not found
                throw new KeyNotFoundException($"Utilisateur with ID {id} not found.");
            }
            return utilisateur;
        }

        public IEnumerable<Utilisateur> GetAllUtilisateurs()
        {
            return _context.Utilisateurs.ToList();
        }

        public void UpdateUtilisateur(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Update(utilisateur);
            _context.SaveChanges();
        }

        public void DeleteUtilisateur(int id)
        {
            var utilisateur = GetUtilisateurById(id);
            if (utilisateur != null)
            {
                _context.Utilisateurs.Remove(utilisateur);
                _context.SaveChanges();
            }
        }
    }
}
