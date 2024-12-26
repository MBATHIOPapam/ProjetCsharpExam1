using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface IProduitService
    {
        void CreateProduit(Produit produit);
        Produit GetProduitById(int id);
        IEnumerable<Produit> GetAllProduits();
        void UpdateProduit(Produit produit);
        void DeleteProduit(int id);
    }
}
