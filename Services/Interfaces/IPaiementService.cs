using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface IPaiementService
    {
        void CreatePaiement(Paiement paiement);
        Paiement GetPaiementById(int id);
        IEnumerable<Paiement> GetAllPaiements();
        void UpdatePaiement(Paiement paiement);
        void DeletePaiement(int id);
    }
}
