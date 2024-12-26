using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface IUtilisateurService
    {
        void CreateUtilisateur(Utilisateur utilisateur);
        Utilisateur GetUtilisateurById(int id);
        IEnumerable<Utilisateur> GetAllUtilisateurs();
        void UpdateUtilisateur(Utilisateur utilisateur);
        void DeleteUtilisateur(int id);
    }
}
