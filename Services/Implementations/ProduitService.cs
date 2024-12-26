using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Services.Implementations
{
    public class ProduitService : IProduitService
    {
        private readonly ApplicationDbContext _context;

        public ProduitService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateProduit(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
        }

        public Produit GetProduitById(int id)
        {
            var produit = _context.Produits.Find(id);
            if (produit == null)
            {
                // Handle the case where the produit is not found
                throw new KeyNotFoundException($"Produit with ID {id} not found.");
            }
            return produit;
        }

        public IEnumerable<Produit> GetAllProduits()
        {
            return _context.Produits.ToList();
        }

        public void UpdateProduit(Produit produit)
        {
            _context.Produits.Update(produit);
            _context.SaveChanges();
        }

        public void DeleteProduit(int id)
        {
            var produit = GetProduitById(id);
            if (produit != null)
            {
                _context.Produits.Remove(produit);
                _context.SaveChanges();
            }
        }
    }
}
