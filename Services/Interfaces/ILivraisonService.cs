using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface ILivraisonService
    {
        void CreateLivraison(Livraison livraison);
        Livraison GetLivraisonById(int id);
        IEnumerable<Livraison> GetAllLivraisons();
        void UpdateLivraison(Livraison livraison);
        void DeleteLivraison(int id);
    }
}
