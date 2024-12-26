using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;

namespace ProjetCsharpExamMbathio.Services.Interfaces
{
    public interface ILivreurService
    {
        void CreateLivreur(Livreur livreur);
        Livreur GetLivreurById(int id);
        IEnumerable<Livreur> GetAllLivreurs();
        void UpdateLivreur(Livreur livreur);
        void DeleteLivreur(int id);
    }
}

