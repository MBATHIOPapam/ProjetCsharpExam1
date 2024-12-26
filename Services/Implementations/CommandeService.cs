using System.Collections.Generic;
using ProjetCsharpExamMbathio.Models.Entities;
using ProjetCsharpExamMbathio.Models.Data;
using ProjetCsharpExamMbathio.Services.Interfaces;

namespace ProjetCsharpExamMbathio.Services.Implementations
{
    public class CommandeService : ICommandeService
    {
        private readonly ApplicationDbContext _context;

        public CommandeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateCommande(Commande commande)
        {
            _context.Commandes.Add(commande);
            _context.SaveChanges();
        }

        public Commande GetCommandeById(int id)
        {
            var commande = _context.Commandes.Find(id);
            if (commande == null)
            {
                // Handle the case where the commande is not found
                throw new KeyNotFoundException($"Commande with ID {id} not found.");
            }
            return commande;
        }

        public IEnumerable<Commande> GetAllCommandes()
        {
            return _context.Commandes.ToList();
        }

        public void UpdateCommande(Commande commande)
        {
            _context.Commandes.Update(commande);
            _context.SaveChanges();
        }

        public void DeleteCommande(int id)
        {
            var commande = GetCommandeById(id);
            if (commande != null)
            {
                _context.Commandes.Remove(commande);
                _context.SaveChanges();
            }
        }

        public void DeclareCommandeRecue(int id)
        {
            var commande = GetCommandeById(id);
            commande.EstRecu = true;
            _context.SaveChanges();
        }
}
}