using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Services.Implementations
{
    public class PaiementService : IPaiementService
    {
        private readonly ApplicationDbContext _context;

        public PaiementService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreatePaiement(Paiement paiement)
        {
            _context.Paiements.Add(paiement);
            _context.SaveChanges();
        }

        public Paiement GetPaiementById(int id)
        {
            var paiement = _context.Paiements.Find(id);
            if (paiement == null)
            {
                // Handle the case where the paiement is not found
                throw new KeyNotFoundException($"Paiement with ID {id} not found.");
            }
            return paiement;
        }

        public IEnumerable<Paiement> GetAllPaiements()
        {
            return _context.Paiements.ToList();
        }

        public void UpdatePaiement(Paiement paiement)
        {
            _context.Paiements.Update(paiement);
            _context.SaveChanges();
        }

        public void DeletePaiement(int id)
        {
            var paiement = GetPaiementById(id);
            if (paiement != null)
            {
                _context.Paiements.Remove(paiement);
                _context.SaveChanges();
            }
        }
    }
}
