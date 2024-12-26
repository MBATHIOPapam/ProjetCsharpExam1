using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface ICommandeService
    {
        void CreateCommande(Commande commande);
        Commande GetCommandeById(int id);
        IEnumerable<Commande> GetAllCommandes();
        void UpdateCommande(Commande commande);
        void DeleteCommande(int id);
        void DeclareCommandeRecue(int id); // Correctly defined method without a body
    }
}
